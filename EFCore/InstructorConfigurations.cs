using EFCorePractice.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Configurations
{
    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.property(I => I.Salary).HascolumnType("decimal(10,3)");
            builder.property(I => I.HourRate).HascolumnType("decimal(10,4)");
            builder.property(I => I.Address).HascolumnType("Damnhour");
            builder.pro
        }
    }
}
        }
    }
}