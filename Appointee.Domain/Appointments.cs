using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointee.Domain
{
  public class Appointments
  {
	public int Id { get; set; }
	public DateTime Date { get; set; }
	public string Location { get; set; }
	public string Agenda { get; set; }
  }
}
