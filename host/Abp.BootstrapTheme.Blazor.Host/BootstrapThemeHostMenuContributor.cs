using System.Threading.Tasks;
using Abp.BootstrapTheme.Management.Localization;
using Volo.Abp.UI.Navigation;

namespace Abp.BootstrapTheme.Blazor.Host
{
    public class BootstrapThemeHostMenuContributor : IMenuContributor
    {
        public Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.DisplayName != StandardMenus.Main)
            {
                return Task.CompletedTask;
            }


            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    "MyProjectName.Home",
                    "首页",
                    "/",
                    icon: "fas fa-home"
                )
            );

            context.Menu.Items.Insert(
                 1,
                 new ApplicationMenuItem(
                     "MyProjectName.form",
                     "表单",
                     "/form",
                     icon: "fas fa-home"
                 )
             );

            context.Menu.Items.Insert(
                 2,
                 new ApplicationMenuItem(
                     "MyProjectName.Counter",
                     "计数器",
                     "/counter",
                     icon: "fas fa-home"
                 )
             );

            context.Menu.Items.Insert(
                 3,
                 new ApplicationMenuItem(
                     "MyProjectName.fetchdata",
                     "fetchdata",
                     "/fetchdata",
                     icon: "fas fa-home"
                 )
             );
            context.Menu.Items.Insert(
                 4,
                 new ApplicationMenuItem(
                     "MyProjectName.syssetting",
                     "系统设置",
                     "/fetchdata",
                     icon: "fa fa-fw fa-gears"
                 )
             );

            context.Menu.Items.Insert(
              5,
              new ApplicationMenuItem(
                  "TreeView",
                  "TreeView",
                  "/treeview/tree1",
                  icon: "fa fa-fw fa-check-square-o"
              )
          );

            context.Menu.Items.Insert(
              6,
              new ApplicationMenuItem(
                  "Grid",
                  "Grid",
                  "/grid/gird2",
                  icon: "fa fa-fw fa-database"
              )
          );
            context.Menu.Items.Insert(
              7,
              new ApplicationMenuItem(
                  "GridAdd",
                  "GridAdd",
                  "/grid/add",
                  icon: "fa fa-fw fa-database"
              )
          );

            context.Menu.Items.Insert(
             7,
             new ApplicationMenuItem(
                 "splitter",
                 "splitter",
                 "/splitter/expand-collapse",
                 icon: "fa fa-fw fa-database"
             )
         );
 

            context.Menu.Items[4].Items.Insert(
                0,
                new ApplicationMenuItem("Tree",
                "树形",
                "/tree",
                icon: "fa fa-fw fa-gears"
                )
           );

            context.Menu.Items[4].Items.Insert(
            1,
            new ApplicationMenuItem("List-1",
            "列表1",
            "/list1",
            icon: "fa fa-fw fa-gears"
            )
            );

            context.Menu.Items[4].Items.Insert(
          2,
          new ApplicationMenuItem("List-2",
          "列表2",
          "/list2",
          icon: "fa fa-fw fa-gears"
          )
          );

            context.Menu.Items[4].Items.Insert(
        3,
        new ApplicationMenuItem("list-list1",
        "list-list1",
        "/list-list1",
        icon: "fa fa-fw fa-gears"
        )
        );

            context.Menu.Items[4].Items.Insert(
            4,
            new ApplicationMenuItem("list-list2",
            "list-list2",
            "/list-list2",
            icon: "fa fa-fw fa-gears"
            )
            );

            context.Menu.Items[4].Items.Insert(
            5,
            new ApplicationMenuItem("list-list2",
            "list-list2",
            "/list-list2",
            icon: "fa fa-fw fa-gears"
            )
            );

            context.Menu.Items[4].Items.Insert(
            6,
            new ApplicationMenuItem("Master_Detail",
            "master_detail",
            "/master_detail",
            icon: "fa fa-fw fa-gears"
            )
            );

            context.Menu.Items[4].Items.Insert(
            7,
            new ApplicationMenuItem("list_detail1",
            "List-Detail1",
            "/list_detail1",
            icon: "fa fa-fw fa-gears"
            )
            );

            context.Menu.Items[4].Items.Insert(
          8,
           new ApplicationMenuItem("list_detail2",
           "List-Detail12",
           "/list_detail2",
           icon: "fa fa-fw fa-gears"
           )
           );

            return Task.CompletedTask;
        }
    }
}