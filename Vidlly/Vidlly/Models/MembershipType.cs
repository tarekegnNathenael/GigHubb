﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidlly.Models
{
    public class MembershipType
    {
        public int Id { get; set; }

        public short SignUpFee { get; set; }

        public byte DurationInMonths { get; set; }

        public byte DiscountRate { get; set; }
        [Required]
        public string Name { get; set; }


        public static readonly int Unknown = 0;
        public static readonly int payAsYouGo = 1;

    }
}