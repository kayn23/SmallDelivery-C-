using System;
using SmallDelivery.Models.Mappings.DTO.InvoiceDto;

namespace SmallDelivery.Models.Mappings.DTO.InvoiceDto
{
  public class InvoiceListDto
  {
    public IList<InvoiceDetailsDto> Invoices { get; set; }
  }
}


