using InnoXMigration.Application.OtherService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application.OtherService.Implementation
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime now => DateTime.Now;
    }
}
