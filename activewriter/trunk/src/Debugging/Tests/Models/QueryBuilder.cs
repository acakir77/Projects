#region license
// Copyright (c) 2005 - 2007 Ayende Rahien (ayende@ayende.com)
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
// 
//     * Redistributions of source code must retain the above copyright notice,
//     this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice,
//     this list of conditions and the following disclaimer in the documentation
//     and/or other materials provided with the distribution.
//     * Neither the name of Ayende Rahien nor the names of its
//     contributors may be used to endorse or promote products derived from this
//     software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE
// FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
// SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
// CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
// OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
// THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
#endregion


using System;
using System.Collections;
using System.Collections.Generic;
using NHibernate.Expression;
using NHibernate.Type;

namespace Query
{
	public partial class QueryBuilder<T>
	{
		protected string myName;
		/// <summary>
		/// This is needed so we can support
		/// Where.Comment.Post == post
		/// And it will turn to Expression.Eq("Post", post)  on the root rather than on a sub
		/// criteria
		/// </summary>
		protected string associationPath;
		private readonly bool backTrackAssociationsOnEquality;
        private readonly IList<OrderByClause> orderByClauses = new List<OrderByClause>(); 
        private readonly ICollection<QueryBuilder<T>> children = new List<QueryBuilder<T>>();
		private readonly ICollection<ICriterion> criterions = new List<ICriterion>();
        private PropertyProjectionBuilder propertyProjection = null;

		public QueryBuilder(string name, string associationPath, bool backTrackAssociationsOnEquality)
		{
			this.myName = name;
			this.associationPath = associationPath;
			this.backTrackAssociationsOnEquality = backTrackAssociationsOnEquality;
		}

		public QueryBuilder(string name, string associationPath)
		{
			this.myName = name;
			this.associationPath = associationPath ?? "this";
		}

		protected void AddCriterion(ICriterion criterion)
		{
			criterions.Add(criterion);
		}

        public QueryBuilder<T> SetProjection(PropertyProjectionBuilder propertyProjection)
        {
            if (propertyProjection == null) throw new ArgumentNullException("propertyProjection");
            this.propertyProjection = propertyProjection;
            return this;

        }

        public QueryBuilder<T> AddOrder(OrderByClause orderByClause)
        {
            this.orderByClauses.Add(orderByClause);
            return this;

        }

        public QueryBuilder<T> AddOrder(params OrderByClause[] orderByClauses)
        {
            if (orderByClauses != null)
            {
                foreach (OrderByClause orderByClause in orderByClauses)
                {
                    AddOrder(orderByClause);
                }
            }
            return this;

        }

		public QueryBuilder<T> Eq(object value)
		{
			AbstractCriterion eq;
			if (value == null)
				eq = Expression.IsNull(myName);
			else
				eq = Expression.Eq(myName, value);
			QueryBuilder<T> self = this;
			if (backTrackAssociationsOnEquality)
			{
				self = new QueryBuilder<T>(myName, BackTrackAssociationPath(associationPath));
				children.Add(self);
			}
			self.AddCriterion(eq);
			return this;
		}


		public QueryBuilder<T> NotEq(object value)
		{
			AbstractCriterion eq;
			if (value == null)
				eq = Expression.IsNotNull(myName);
			else
				eq = Expression.Not(Expression.Eq(myName, value));
			QueryBuilder<T> self = this;
			if (backTrackAssociationsOnEquality)
			{
				self = new QueryBuilder<T>(myName, BackTrackAssociationPath(associationPath));
				children.Add(self);
			}
			self.AddCriterion(eq);
			return this;
		}

		public QueryBuilder<T> In<K>(params K[] values)
		{
			AbstractCriterion inExpression = Expression.In(myName, values);
			QueryBuilder<T> self = this;
			if (backTrackAssociationsOnEquality)
			{
				self = new QueryBuilder<T>(myName, BackTrackAssociationPath(associationPath));
				children.Add(self);
			}
			self.AddCriterion(inExpression);
			return this;
		}

		public QueryBuilder<T> In(params object[] values)
		{
			In((ICollection)values);
			return this;
		}

		public QueryBuilder<T> In<K>(ICollection<K> values)
		{
			In(new List<K>(values).ToArray());
			return this;
		}

		public QueryBuilder<T> In<K>(IEnumerable<K> values)
		{
			In(new List<K>(values).ToArray());
			return this;
		}

		public QueryBuilder<T> IsNotNull
		{
			get
			{
				AbstractCriterion notNullExpression = new NotNullExpression(myName);
				QueryBuilder<T> self = this;
				if (backTrackAssociationsOnEquality)
				{
					self = new QueryBuilder<T>(myName, BackTrackAssociationPath(associationPath));
					children.Add(self);
				}
				self.AddCriterion(notNullExpression);
				return this;
			}
		}

		public QueryBuilder<T> IsNull
		{
			get
			{
				AbstractCriterion nullExpression = new NullExpression(myName);
				QueryBuilder<T> self = this;
				if (backTrackAssociationsOnEquality)
				{
					self = new QueryBuilder<T>(myName, BackTrackAssociationPath(associationPath));
					children.Add(self);
				}
				self.AddCriterion(nullExpression);
				return this;
			}
		}

		public static QueryBuilder<T> operator ==(QueryBuilder<T> expr, object other)
		{
			return expr.Eq(other);
		}

		public static QueryBuilder<T> operator !=(QueryBuilder<T> expr, object other)
		{
			return expr.NotEq(other);
		}

		public static QueryBuilder<T> operator &(QueryBuilder<T> lhs, QueryBuilder<T> rhs)
		{
			QueryBuilder<T> combined = new QueryBuilder<T>(lhs.myName, null);
			combined.children.Add(lhs);
			combined.children.Add(rhs);
			return combined;
		}
		
		public static QueryBuilder<T> operator !(QueryBuilder<T> other)
		{
			QueryBuilder<T> not = new QueryBuilder<T>(other.myName, null);
			if(other.children.Count!=0)
			{
				throw new InvalidOperationException("Cannot use ! operator on complex queries");
			}
			Conjunction conjunction = new Conjunction();
			foreach(ICriterion crit in other.criterions)
			{
				conjunction.Add(crit);
			}
			not.AddCriterion(Expression.Not(conjunction));
			return not;
		}
		
		public static QueryBuilder<T> operator |(QueryBuilder<T> lhs, QueryBuilder<T> rhs)
		{
			if (lhs.associationPath != rhs.associationPath)
			{
				throw new InvalidOperationException(
					string.Format(
						@"OR attempted between {0} and {1}.
You can't OR between two Query parts that belong to different associations.
Use HQL for this functionality...",
						lhs.associationPath,
						rhs.associationPath));
			}

			QueryBuilder<T> combined = new QueryBuilder<T>(lhs.myName, null);
			Conjunction lhs_conjunction = Expression.Conjunction();
			Conjunction rhs_conjunction = Expression.Conjunction();
			foreach (ICriterion criterion in lhs.criterions)
			{
				lhs_conjunction.Add(criterion);
			}
			foreach (ICriterion criterion in rhs.criterions)
			{
				rhs_conjunction.Add(criterion);
			}
			combined.criterions.Add(Expression.Or(lhs_conjunction, rhs_conjunction));
			return combined;
		}

		public static bool operator true(QueryBuilder<T> exp)
		{
			return false;
		}

		public static bool operator false(QueryBuilder<T> exp)
		{
			return false;
		}
		
		public static implicit operator DetachedCriteria(QueryBuilder<T> expr)
		{
			return expr.ToDetachedCriteria(null);
		}

		public DetachedCriteria ToDetachedCriteria()
		{
			return ToDetachedCriteria(null);
		}

		public DetachedCriteria ToDetachedCriteria(string alias)
		{
			DetachedCriteria detachedCriteria;
			if (String.IsNullOrEmpty(alias))
				detachedCriteria = DetachedCriteria.For(typeof( T ));
			else
				detachedCriteria = DetachedCriteria.For( typeof( T ), alias );

            if (this.propertyProjection != null)
            {
                ProjectionList projectionList = this.propertyProjection;
                detachedCriteria.SetProjection(projectionList);
            }
            foreach (OrderByClause orderByClause in orderByClauses)
            {
                detachedCriteria.AddOrder(orderByClause);
            }

			Dictionary<string, ICollection<ICriterion>> criterionsByAssociation = new Dictionary<string, ICollection<ICriterion>>();
			AddByAssociationPath( criterionsByAssociation );

			foreach (KeyValuePair<string, ICollection<ICriterion>> pair in criterionsByAssociation)
			{
				DetachedCriteria temp = detachedCriteria;
				if (pair.Key != "this")
					temp = detachedCriteria.CreateCriteria(pair.Key);
				foreach (ICriterion criterion in pair.Value)
				{
					temp.Add(criterion);
				}
			}
			return detachedCriteria;
		}

		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.Localizable(false)]
		public override bool Equals(object obj)
		{
			throw new InvalidOperationException("You can't use Equals()! Use Eq()");
		}


		[System.ComponentModel.Browsable(false)]
		[System.ComponentModel.Localizable(false)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		protected static QueryBuilder<T> FromCriterion(AbstractCriterion criterion,
			string name, string associationPath)
		{
			QueryBuilder<T> queryBuilder = new QueryBuilder<T>(name, associationPath);
			queryBuilder.AddCriterion(criterion);
			return queryBuilder;
		}


		protected static string BackTrackAssociationPath(string associationPath)
		{
			int lastIndexOfPeriod = associationPath.LastIndexOf('.');
			if (lastIndexOfPeriod == -1)//this mean we are on "this", no need to do anything
				return associationPath;
			return associationPath.Substring(0, lastIndexOfPeriod);

		}

		private void AddByAssociationPath(IDictionary<string, ICollection<ICriterion>> criterionsByAssociation)
		{
			if (criterionsByAssociation.ContainsKey(associationPath) == false)
				criterionsByAssociation.Add(associationPath, new List<ICriterion>());
			foreach (ICriterion criterion in criterions)
			{
				criterionsByAssociation[associationPath].Add(criterion);
			}
			foreach (QueryBuilder<T> child in children)
			{
				child.AddByAssociationPath(criterionsByAssociation);
			}
		}
	}

	public partial class PropertyQueryBuilder<T> : QueryBuilder<T>
	{
		public PropertyQueryBuilder(string name, string associationPath)
			: base(name, associationPath)
		{
		}

		public QueryBuilder<T> Between(object lo, object hi)
		{
			AbstractCriterion betweenExpression = new BetweenExpression(myName, lo, hi);
			AddCriterion(betweenExpression);
			return this;
		}

		public QueryBuilder<T> EqProperty(string otherPropertyName)
		{
			AbstractCriterion eqPropertyExpression = new EqPropertyExpression(myName, otherPropertyName);
			AddCriterion(eqPropertyExpression);
			return this;
		}


		public QueryBuilder<T> Ge(object value)
		{
			AbstractCriterion geExpression = new GeExpression(myName, value);
			AddCriterion(geExpression);
			return this;
		}

		public QueryBuilder<T> Gt(object value)
		{
			AbstractCriterion gtExpression = new GtExpression(myName, value);
			AddCriterion(gtExpression);
			return this;
		}

		public QueryBuilder<T> InsensitiveLike(object value)
		{
			AbstractCriterion insensitiveLikeExpression = new InsensitiveLikeExpression(myName, value);
			AddCriterion(insensitiveLikeExpression);
			return this;
		}

		public QueryBuilder<T> InsensitiveLike(string value, MatchMode matchMode)
		{
			AbstractCriterion insensitiveLikeExpression = new InsensitiveLikeExpression(myName, value, matchMode);
			AddCriterion(insensitiveLikeExpression);
			return this;
		}
		public QueryBuilder<T> Le(object value)
		{
			AbstractCriterion leExpression = new LeExpression(myName, value);
			AddCriterion(leExpression);
			return this;
		}

		public QueryBuilder<T> LeProperty(string otherPropertyName)
		{
			AbstractCriterion lePropertyExpression = new LePropertyExpression(myName, otherPropertyName);
			AddCriterion(lePropertyExpression);
			return this;
		}

		public QueryBuilder<T> Like(object value)
		{
			AbstractCriterion likeExpression = new LikeExpression(myName, value);
			AddCriterion(likeExpression);
			return this;
		}

		public QueryBuilder<T> Like(string value, MatchMode matchMode)
		{
			AbstractCriterion likeExpression = new LikeExpression(myName, value, matchMode);
			AddCriterion(likeExpression);
			return this;
		}

		public QueryBuilder<T> Lt(object value)
		{
			AbstractCriterion ltExpression = new LtExpression(myName, value);
			AddCriterion(ltExpression);
			return this;
		}

		public QueryBuilder<T> LtProperty(string otherPropertyName)
		{
			AbstractCriterion ltPropertyExpression = new LtPropertyExpression(myName, otherPropertyName);
			AddCriterion(ltPropertyExpression);
			return this;
		}

		public static QueryBuilder<T> operator >(PropertyQueryBuilder<T> expr, object other)
		{
			return expr.Gt(other);
		}

		public static QueryBuilder<T> operator <(PropertyQueryBuilder<T> expr, object other)
		{
			return expr.Lt(other);
		}

		public static QueryBuilder<T> operator >=(PropertyQueryBuilder<T> expr, object other)
		{
			return expr.Ge(other);
		}

		public static QueryBuilder<T> operator <=(PropertyQueryBuilder<T> expr, object other)
		{
			return expr.Le(other);
		}
	}

	public partial class OrderByClause
	{
		bool ascending = true;
		string name;

		public OrderByClause(string name)
		{
			this.name = name;
		}

		public OrderByClause Asc
		{
			get
			{
				ascending = true;
				return this;
			}
		}

		public OrderByClause Desc
		{
			get
			{
				ascending = false;
				return this;
			}
		}

		public static implicit operator Order(OrderByClause order)
		{
			return new Order(order.name, order.ascending);
		}
	}

	public partial class ProjectBy
	{
		public static IProjection RowCount
		{
			get { return Projections.RowCount(); }
		}

		public static IProjection Id
		{
			get { return Projections.Id(); }
		}

		public static IProjection Distinct(IProjection projection)
		{
			return Projections.Distinct(projection);
		}

		public static IProjection SqlProjection(string sql, string[] aliases, IType[] types)
		{
			return Projections.SqlProjection(sql, aliases, types);
		}

		public static IProjection SqlGroupByProjection(string sql, string groupBy, string[] aliases, IType[] types)
		{
			return Projections.SqlGroupProjection(sql, groupBy, aliases, types);
		}
	}


	public partial class PropertyProjectionBuilder
	{
		protected string name;
		ProjectionList list;

		public PropertyProjectionBuilder(string name)
		{
			this.name = name;
		}

		public IProjection Count
		{
			get { return Projections.Count(name); }
		}

		public IProjection DistinctCount
		{
			get { return Projections.CountDistinct(name); }
		}

		public IProjection Max
		{
			get { return Projections.Max(name); }
		}

		public IProjection Min
		{
			get { return Projections.Min(name); }
		}


		#region Operator Overloading Magic

		public static implicit operator ProjectionList(PropertyProjectionBuilder projection)
		{
			if (projection.list != null)
				return projection.list;
			return Projections.ProjectionList()
				.Add(Projections.Property(projection.name));
		}

		public static PropertyProjectionBuilder operator &(PropertyProjectionBuilder lhs, PropertyProjectionBuilder rhs)
		{
			if (lhs.list != null)
			{
				if (rhs.list == null)
				{
					lhs.list.Add(Projections.Property(rhs.name));
				}
				else
				{
					lhs.list.Add(rhs.list);
				}
				return lhs;
			}
			lhs.list = Projections.ProjectionList()
				.Add(Projections.Property(lhs.name))
				.Add(Projections.Property(rhs.name));
			return lhs;
		}


		public static bool operator true(PropertyProjectionBuilder exp)
		{
			return false;
		}

		public static bool operator false(PropertyProjectionBuilder exp)
		{
			return false;
		}

		#endregion

	}

	public partial class NumericPropertyProjectionBuilder : PropertyProjectionBuilder
	{
		public NumericPropertyProjectionBuilder(string name) : base(name) { }

		public IProjection Avg
		{
			get { return Projections.Avg(name); }
		}

		public IProjection Sum
		{
			get { return Projections.Sum(name); }
		}

		public static implicit operator PropertyProjection(NumericPropertyProjectionBuilder projection)
		{
			return Projections.Property(projection.name);
		}
	}
}
