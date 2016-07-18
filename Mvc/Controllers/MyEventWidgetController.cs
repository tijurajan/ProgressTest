using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Mvc;
using Telerik.Sitefinity.ContentLocations;
using Telerik.Sitefinity.Events.Model;
using Telerik.Sitefinity.Frontend.Events.Mvc.Models;
using Telerik.Sitefinity.Frontend.Events.Mvc.StringResources;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers.Attributes;
using Telerik.Sitefinity.Modules.Pages.Configuration;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Services;
using Telerik.Sitefinity.Taxonomies.Model;
using Telerik.Sitefinity.Localization;
using Telerik.Sitefinity.Localization.Data;





namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "MyEventWidget", Title = "MyEventWidget", SectionName = "MvcWidgets")]
    public class MyEventWidgetController : Controller, IContentLocatableView
    {

        
      

        /// <summary>
        /// Gets the Events widget model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public virtual IEventModel Model
        {
            get
            {
                if (this.model == null)
                    this.model = ControllerModelFactory.GetModel<IEventModel>(this.GetType());

                return this.model;
            }
        }

        /// <summary>
        /// Gets or sets the name of the template that will be displayed when widget is in List view.
        /// </summary>
        /// <value>
        /// The name of the list template.
        /// </value>
        public string ListTemplateName
        {
            get
            {
                return this.listTemplateName;
            }

            set
            {
                this.listTemplateName = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the template that will be displayed when widget is in Detail view.
        /// </summary>
        /// <value>
        /// The name of the details template.
        /// </value>
        public string DetailTemplateName
        {
            get
            {
                return this.detailTemplateName;
            }

            set
            {
                this.detailTemplateName = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether detail view for the event should be opened in the same page.
        /// </summary>
        /// <value>
        /// <c>true</c> if details link should be opened in the same page; otherwise, (if should redirect to custom selected page)<c>false</c>.
        /// </value>
        public bool OpenInSamePage
        {
            get
            {
                return this.openInSamePage;
            }

            set
            {
                this.openInSamePage = value;
            }
        }

        /// <summary>
        /// Gets or sets the id of the page where will be displayed details view for selected item.
        /// </summary>
        /// <value>
        /// The details page id.
        /// </value>
        public Guid DetailsPageId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the canonical URL tag should be added to the page when the canonical meta tag should be added to the page.
        /// If the value is not set, the settings from SystemConfig -> ContentLocationsSettings -> DisableCanonicalURLs will be used. 
        /// </summary>
        /// <value>The disable canonical URLs.</value>
        public bool? DisableCanonicalUrlMetaTag
        {
            get
            {
                return this.disableCanonicalUrlMetaTag;
            }

            set
            {
                this.disableCanonicalUrlMetaTag = value;
            }
        }



        public object selectedItem



        {



            get;
                


            set ; 



        }







        public string selectedId

        {

            get;



            set;


        }
       

        /// <summary>
        /// Renders appropriate list view depending on the <see cref="ListTemplateName" />
        /// </summary>
        /// <param name="page">The page.</param>
        /// <returns>
        /// The <see cref="ActionResult" />.
        /// </returns>
        public ActionResult Index(int? page)
        {
            var viewModel = this.Model.CreateListViewModel(null, page: page ?? 1);

            this.InitializeListViewBag("/{0}");

            if (SystemManager.CurrentHttpContext != null)
                this.AddCacheDependencies(this.Model.GetKeysOfDependentObjects(viewModel));

            var fullTemplateName = MyEventWidgetController.ListTemplateNamePrefix + this.ListTemplateName;
            return this.View(fullTemplateName, viewModel);
        }
        /// <summary>
        /// Renders appropriate list view depending on the <see cref="ListTemplateName" /> 
        /// </summary>
        /// <param name="taxonFilter">The taxonomy filter.</param>
        /// <param name="page">The page.</param>
        /// <returns>
        /// The <see cref="ActionResult" />.
        /// </returns>
        public ActionResult ListByTaxon(ITaxon taxonFilter, int? page)
        {
            var fullTemplateName =  MyEventWidgetController.ListTemplateNamePrefix + this.ListTemplateName;
            this.InitializeListViewBag("/" + taxonFilter.UrlName + "/{0}");

            var viewModel = this.Model.CreateListViewModel(taxonFilter, page ?? 1);
            if (SystemManager.CurrentHttpContext != null)
                this.AddCacheDependencies(this.Model.GetKeysOfDependentObjects(viewModel));

            return this.View(fullTemplateName, viewModel);
        }

        /// <summary>
        /// Renders appropriate details view depending on the <see cref="DetailTemplateName"/>
        /// </summary>
        /// <param name="item">The item which details will be displayed.</param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Details(Event item)
        {
            var viewModel = this.Model.CreateDetailsViewModel(item);

            this.InitializeDetailsViewBag(item);

            if (SystemManager.CurrentHttpContext != null)
                this.AddCacheDependencies(this.Model.GetKeysOfDependentObjects(viewModel));

            var fullTemplateName = MyEventWidgetController.DetailTemplateNamePrefix + this.DetailTemplateName;
            return this.View(fullTemplateName, viewModel);
        }

        /// <summary>
        /// Gets the information for all of the content types that a control is able to show.
        /// </summary>
        /// <returns>
        /// List of location info of the content that this control is able to show.
        /// </returns>
        [NonAction]
        public virtual IEnumerable<IContentLocationInfo> GetLocations()
        {
            return this.Model.GetLocations();
        }

        /// <summary>
        /// Called when a request matches this controller, but no method with the specified action name is found in the controller.
        /// </summary>
        /// <param name="actionName">The name of the attempted action.</param>
        protected override void HandleUnknownAction(string actionName)
        {
            this.Index(null).ExecuteResult(this.ControllerContext);
        }

        /// <summary>
        /// Initializes the ListView bag.
        /// </summary>
        /// <param name="redirectPageUrl">The redirect page URL.</param>
        private void InitializeListViewBag(string redirectPageUrl)
        {
            this.ViewBag.CurrentPageUrl = SystemManager.CurrentHttpContext != null ? this.GetCurrentPageUrl() : string.Empty;
            this.ViewBag.RedirectPageUrlTemplate = this.ViewBag.CurrentPageUrl + redirectPageUrl;
            this.ViewBag.ItemsPerPage = this.Model.ItemsPerPage;
            this.ViewBag.AllowCalendarExport = this.Model.AllowCalendarExport;
            this.ViewBag.OpenInSamePage = this.OpenInSamePage;
            this.ViewBag.DetailsPageId = this.DetailsPageId;
        }

        /// <summary>
        /// Initializes the DetailsView bag.
        /// </summary>
        /// <param name="item">The event.</param>
        private void InitializeDetailsViewBag(Event item)
        {
            if (item != null)
                this.ViewBag.Title = item.Title;

            this.ViewBag.AllowCalendarExport = this.Model.AllowCalendarExport;
        }

        private const string WidgetIconCssClass = "sfEventsViewIcn sfMvcIcn";
        private const string ListTemplateNamePrefix = "List.";
        private const string DetailTemplateNamePrefix = "Detail.";

        private IEventModel model;
        private bool openInSamePage = true;

        private string listTemplateName = "EventsList";
        private string detailTemplateName = "EventDetails";
        private bool? disableCanonicalUrlMetaTag;
    }
}