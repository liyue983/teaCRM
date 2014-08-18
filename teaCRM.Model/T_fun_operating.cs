//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

namespace teaCRM.Model
{
    public partial class T_fun_operating
    {
        #region Primitive Properties
    	[Required]
    	public virtual int id
        {
            get;
            set;
        }
    	[Required]
    	public virtual int myapp_id
        {
            get { return _myapp_id; }
            set
            {
                if (_myapp_id != value)
                {
                    if (T_fun_myapp != null && T_fun_myapp.id != value)
                    {
                        T_fun_myapp = null;
                    }
                    _myapp_id = value;
                }
            }
        }
        private int _myapp_id;
    	//[Required]
        [MaxLength(200)]
    	public virtual string myapp_name
        {
            get;
            set;
        }
    	[Required]
        [MaxLength(100)]
    	public virtual string ope_action
        {
            get;
            set;
        }
    	[Required]
    	public virtual int ope_is_sys
        {
            get;
            set;
        }
    	[Required]
    	public virtual int ope_is_status
        {
            get;
            set;
        }
    	[Required]
    	public virtual int ope_is_fast
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual T_fun_myapp T_fun_myapp
        {
            get { return _t_fun_myapp; }
            set
            {
                if (!ReferenceEquals(_t_fun_myapp, value))
                {
                    var previousValue = _t_fun_myapp;
                    _t_fun_myapp = value;
                    FixupT_fun_myapp(previousValue);
                }
            }
        }
        private T_fun_myapp _t_fun_myapp;

        #endregion
        #region Association Fixup
    
        private void FixupT_fun_myapp(T_fun_myapp previousValue)
        {
            if (previousValue != null && previousValue.T_fun_operating.Contains(this))
            {
                previousValue.T_fun_operating.Remove(this);
            }
    
            if (T_fun_myapp != null)
            {
                if (!T_fun_myapp.T_fun_operating.Contains(this))
                {
                    T_fun_myapp.T_fun_operating.Add(this);
                }
                if (myapp_id != T_fun_myapp.id)
                {
                    myapp_id = T_fun_myapp.id;
                }
            }
        }

        #endregion
    }
}