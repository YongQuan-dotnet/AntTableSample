using AntDesign.TableModels;
using AntTableSample.Portal.DataContext;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace AntTableSample.Portal.Pages
{
    public partial class Index : IDisposable
    {
        [Inject]
        IDbContextFactory<PropertyDbContext> DbContextFactory { get; set; }

        private PropertyDbContext DbContext;

        private IQueryable<Property> Properties { get; set; }

        protected override async Task OnInitializedAsync()
        {
            DbContext = DbContextFactory.CreateDbContext();
            Properties = DbContext.Properties;
        }

        public void Dispose()
        {
            DbContext?.Dispose();
        }
    }
}
