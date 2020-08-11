using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BurnOut.Data.Models
{
    [Table("SocialNetworkInfo", Schema = "burnOut")]
    class SocialInfo
    {
        [Key]
        public int Id { get; set; }

        [Column("FaceBook_Profile_URL")]
        public string Facebook_URL { get; set; }

        [Column("Instagram_Profile_URL")]
        public string Instagram_URL { get; set; }
    }
}
