# How to create an ASPxGridView descendant class



### Important notice:

Don't create descendants of our controls without a serious reason:

* Descendants have issues with themes: [Why a theme / skin file is not applied to an ASP.NET control descendant?](https://supportcenter.devexpress.com/ticket/details/ka18892/why-a-theme-skin-file-is-not-applied-to-an-asp-net-control-descendant).
* The hierarchy of their inner controls can be recreated multiple times due to the complex nature of our controls (especially, large ones - ASPxGridView, ASPxTreeList, ASPxFileManager, etc). This should be taken into account during development.
* It's hard to rely on internal properties and fields without the source code and the ability to debug incorrect behavior.
* A custom descendant may use internal functionality that can be removed or changed in new versions without any notice.
* A custom implementation may differ from our original code significantly, so we don't offer support for such solutions.


If you wish to specify common settings and logic for all controls of the same type, the recommended solutions are:

* [Web User Control](https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.usercontrol?view=netframework-4.8).
* A helper class that uses our public API. You can find an example of implementation here: [T754558](https://supportcenter.devexpress.com/ticket/details/t754558/redefining-aspxgridview-aspxgridviewsettings-in-a-descendant-class).

### Description:
<p>This example shows a simple ASPxGridView descendant class. The CustomGridViewDesigner class supports design-time editing capabilities for the CustomGridView control.</p>



