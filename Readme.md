# How to synchronize scrollbars of XtraScheduler controls


<p>I have a form with two XtraScheduler controls on it. I want to  synchronize scrollbars of both controls in the Timeline view so they scroll as if it is the one control. Can you tell me how to achieve that?</p>


<h3>Description</h3>

<p>Please handle the <a href="http://www.devexpress.com/Help/?document=xtrascheduler/devexpressxtraschedulerschedulercontrol_visibleintervalchangedtopic.htm">SchedulerControl.VisibleIntervalChanged</a> to synchronize the horizontal scrollbars in the XtraScheduler control. To synchronize vertical scrollbars, you should handle the <a href="http://www.devexpress.com/Help/?document=xtrascheduler/devexpressxtraschedulerschedulercontrol_customdrawresourceheadertopic.htm">SchedulerControl.CustomDrawResourceHeader</a> event .</p>

<br/>


