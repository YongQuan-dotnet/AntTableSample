using AntDesign.TableModels;
using AntTableSample.Portal.DataContext;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace AntTableSample.Portal.Pages
{
    public partial class Index
    {
        [Inject]
        IDbContextFactory<PropertyDbContext> DbContextFactory { get; set; }

        private IQueryable<Property> Properties { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var context = DbContextFactory.CreateDbContext();
            Properties = context.Properties;
        }
    }
}
