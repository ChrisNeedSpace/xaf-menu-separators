using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.SystemModule;
using SampleProject.Module.Infrastructure;

namespace SampleProject.Module.Web.Infrastructure
{
    public class NavigationItemController : Controller 
    {
        ShowNavigationItemController controller;
        protected override void OnFrameAssigned()
        {
            base.OnFrameAssigned();
            controller = Frame.GetController<ShowNavigationItemController>();
            controller.ItemsInitialized -= CustomizeShowNamvigationItemController_ItemsInitialized;
            controller.ItemsInitialized += CustomizeShowNamvigationItemController_ItemsInitialized;
        }

        protected override void OnDeactivated()
        {
            if (controller != null)
                controller.ItemsInitialized -= CustomizeShowNamvigationItemController_ItemsInitialized;
            base.OnDeactivated();
        }

        void CustomizeShowNamvigationItemController_ItemsInitialized(object sender, EventArgs e)
        {
            EnableBeginGroup(((ShowNavigationItemController)sender).ShowNavigationItemAction.Items, (IModelNavigationItems)Application.Model.GetNode("NavigationItems").GetNode("Items"));
        }
        private void EnableBeginGroup(ChoiceActionItemCollection items, IModelNavigationItems itemsModel)
        {
            foreach (ChoiceActionItem item in items)
            {
                IModelNavigationItem itemModel = itemsModel != null ? itemsModel.GetNode(item.Id) as IModelNavigationItem : null;
                item.BeginGroup = itemModel != null ? ((IModelNavigationItemSeparator)itemModel).BeginGroup : false;
                EnableBeginGroup(item.Items, itemModel != null ? itemModel.GetNode("Items") as IModelNavigationItems : null);
            }
        }
    }
}