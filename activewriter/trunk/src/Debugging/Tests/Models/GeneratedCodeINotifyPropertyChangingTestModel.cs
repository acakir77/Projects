﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Debugging.Tests {
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using Castle.ActiveRecord;
    using System.ComponentModel;
    
    
    [ActiveRecord()]
    public partial class NotifyChangingClass : ActiveRecordBase<NotifyChangingClass>, INotifyPropertyChanging {
        
        private string _notifyChangingProperty;
        
        [Property(ColumnType="String")]
        public virtual string NotifyChangingProperty {
            get {
                return this._notifyChangingProperty;
            }
            set {
                if (((_notifyChangingProperty == value) 
                            == false)) {
                    this.NotifyPropertyChanging("NotifyChangingProperty");
                    this._notifyChangingProperty = value;
                }
            }
        }
        
        #region INotifyPropertyChanging Members
        public event PropertyChangingEventHandler PropertyChanging;
        
        protected virtual void NotifyPropertyChanging(string information) {
            if ((PropertyChanging != null)) {
                PropertyChanging(this, new PropertyChangingEventArgs(information));
            }
        }
        #endregion
    }
}
