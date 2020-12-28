using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pubsProject.Models
{
    public class Card
    {
        [Key]
        [Required(ErrorMessage = "Card number can not be empty")]
        public string card_no { get; set; }
        [Required(ErrorMessage = "Card holder name can not be empty")]
        public string card_holders_name { get; set; }
        [Required(ErrorMessage = "Exp_month can not be empty")]
        public int Exp_month { get; set; }
        [Required(ErrorMessage = "Exp_year can not be empty")]
        public int Exp_year { get; set; }

        public Card(string card_no, string card_holders_name, int exp_month, int exp_year)
        {
            this.card_no = card_no;
            this.card_holders_name = card_holders_name;
            Exp_month = exp_month;
            Exp_year = exp_year;
        }

        public Card()
        {
        }
    }
}