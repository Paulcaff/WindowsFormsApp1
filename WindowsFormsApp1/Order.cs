﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Order
    {
        private int OrderId;
        private string OrderDate;
        private float OrderValue;
        private int SupplierId;
        private string Status;

        public Order()
        {
            OrderId = 0;
            OrderDate = "";
            OrderValue = 0.0f;
            SupplierId = 0;
            Status = "";
        }

        public Order(int OrderId,string OrderDate,float OrderValue, int SupplierId,string Status)
        {
            this.OrderId = OrderId;
            this.OrderDate = OrderDate;
            this.OrderValue = OrderValue;
            this.SupplierId = SupplierId;
            this.Status = Status;
        }

        public void setOrderId(int OrderId)
        {
            this.OrderId = OrderId;
        }

        public void setOrderDate(string OrderDate)
        {
            this.OrderDate = OrderDate;
        }

        public void setOrderValue(float OrderValue)
        {
            this.OrderValue = OrderValue;
        }

        public void setSupplierId(int SupplierId)
        {
            this.SupplierId = SupplierId;
        }

        public void setStatus(string Status)
        {
            this.Status = Status;
        }

        public int getOrderID()
        {
            return OrderId;
        }

        public string getOrderDate()
        {
            return OrderDate;
        }

        public float getOrderValue()
        {
            return OrderValue;
        }

        public int getSupplierId()
        {
            return SupplierId;
        }

        public string getStatus()
        {
            return Status;
        }





    }
}