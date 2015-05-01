using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Domain.Model
{
    public class ShoppingCartItem : AggregateRoot
    {
        public int Quantity { get; set; }

        public Product Product { get; set; }

        public ShoppingCart ShoopingCart { get; set; }

        public decimal ItemAmount
        {
            get
            {
                return this.Product.UnitPrice * this.Quantity;
            }
        }

        #region  Public Methods

        // 将当前的购物车中的项目转换为订单项
        public OrderItem ConvertToOrderItem()
        {
            OrderItem orderItem = new OrderItem();
            orderItem.Id = Guid.NewGuid(); // 为每个SalesLine设置一个不同的ID，以便EF的Context能够识别不同的OrderItem
            orderItem.Product = this.Product;
            orderItem.Quantity = this.Quantity;
            return orderItem;
        }

        public void UpdateQuantity(int quantity)
        {
            this.Quantity = quantity;
        }
        #endregion 
    }
}
