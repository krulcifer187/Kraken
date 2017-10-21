﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace mess.EntFrame
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MyDataEntities5 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MyDataEntities5 object using the connection string found in the 'MyDataEntities5' section of the application configuration file.
        /// </summary>
        public MyDataEntities5() : base("name=MyDataEntities5", "MyDataEntities5")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MyDataEntities5 object.
        /// </summary>
        public MyDataEntities5(string connectionString) : base(connectionString, "MyDataEntities5")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MyDataEntities5 object.
        /// </summary>
        public MyDataEntities5(EntityConnection connection) : base(connection, "MyDataEntities5")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Item_Table> Item_Table
        {
            get
            {
                if ((_Item_Table == null))
                {
                    _Item_Table = base.CreateObjectSet<Item_Table>("Item_Table");
                }
                return _Item_Table;
            }
        }
        private ObjectSet<Item_Table> _Item_Table;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Item_Table EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToItem_Table(Item_Table item_Table)
        {
            base.AddObject("Item_Table", item_Table);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MyDataModel2", Name="Item_Table")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Item_Table : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Item_Table object.
        /// </summary>
        /// <param name="itemID">Initial value of the ItemID property.</param>
        /// <param name="item">Initial value of the item property.</param>
        /// <param name="quant">Initial value of the quant property.</param>
        public static Item_Table CreateItem_Table(global::System.Int32 itemID, global::System.String item, global::System.Int32 quant)
        {
            Item_Table item_Table = new Item_Table();
            item_Table.ItemID = itemID;
            item_Table.item = item;
            item_Table.quant = quant;
            return item_Table;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ItemID
        {
            get
            {
                return _ItemID;
            }
            set
            {
                if (_ItemID != value)
                {
                    OnItemIDChanging(value);
                    ReportPropertyChanging("ItemID");
                    _ItemID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ItemID");
                    OnItemIDChanged();
                }
            }
        }
        private global::System.Int32 _ItemID;
        partial void OnItemIDChanging(global::System.Int32 value);
        partial void OnItemIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String item
        {
            get
            {
                return _item;
            }
            set
            {
                OnitemChanging(value);
                ReportPropertyChanging("item");
                _item = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("item");
                OnitemChanged();
            }
        }
        private global::System.String _item;
        partial void OnitemChanging(global::System.String value);
        partial void OnitemChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 quant
        {
            get
            {
                return _quant;
            }
            set
            {
                OnquantChanging(value);
                ReportPropertyChanging("quant");
                _quant = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("quant");
                OnquantChanged();
            }
        }
        private global::System.Int32 _quant;
        partial void OnquantChanging(global::System.Int32 value);
        partial void OnquantChanged();

        #endregion

    
    }

    #endregion

    
}