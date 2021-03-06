﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Prices2.Models
{
    public class OfferDet
    {
        public int ID { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        [MaxLength(50)]
        public string System { get; set; }
        [MaxLength(50)]
        public string GlassLam { get; set; }
        [MaxLength(50)]
        public string Direction { get; set; }
        [MaxLength(50)]
        public string GlassQnt { get; set; }
        public short Width { get; set; }
        public short Height { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public OfferMas OfferMas { get; set; }
        [ForeignKey("OfferMas")]
        public int BasketMas_ID { get; set; }
        [MaxLength(50)]
        [ForeignKey("Colors")]
        public string ColorName { get; set; }
        public Colors Colors { get; set; }
        [MaxLength(150)]
        public string DoorHandle { get; set; }
        [MaxLength(550)]
        public string FormData { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [MaxLength(1200)]
        public string Extra { get; set; }
        [MaxLength(150)]
        public string Note { get; set; }
        [MaxLength(50)]
        public string LatoD { get; set; }
    }
}