<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2264)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/TwoSchedulers/Form1.cs) (VB: [Form1.vb](./VB/TwoSchedulers/Form1.vb))
<!-- default file list end -->
# How to synchronize scrollbars of XtraScheduler controls


<p>I have a form with two XtraScheduler controls on it. I want to  synchronize scrollbars of both controls in the Timeline view so they scroll as if it is the one control. Can you tell me how to achieve that?</p>


<h3>Description</h3>

<p>Please handle the <a href="http://www.devexpress.com/Help/?document=xtrascheduler/devexpressxtraschedulerschedulercontrol_visibleintervalchangedtopic.htm">SchedulerControl.VisibleIntervalChanged</a> to synchronize the horizontal scrollbars in the XtraScheduler control. To synchronize vertical scrollbars, you should handle the <a href="http://www.devexpress.com/Help/?document=xtrascheduler/devexpressxtraschedulerschedulercontrol_customdrawresourceheadertopic.htm">SchedulerControl.CustomDrawResourceHeader</a> event .</p>

<br/>


