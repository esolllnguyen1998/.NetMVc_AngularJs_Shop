using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }
        [MaxLength(256)]
        string CreateBy { get; set; }
        DateTime? UpdateDate { get; set; }
        [MaxLength(256)]
        string UpdateBy { get; set; }
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }
        bool Status { get; set; }

    }
}