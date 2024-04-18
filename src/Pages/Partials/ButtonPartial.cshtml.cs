#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.Dashboard.Management.v2.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 2 "..\..\Pages\Partials\ButtonPartial.cshtml"
    using Hangfire.Dashboard.Management.v2;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Pages\Partials\ButtonPartial.cshtml"
    using Hangfire.Dashboard.Management.v2.Pages;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Pages\Partials\ButtonPartial.cshtml"
    using Hangfire.Dashboard.Management.v2.Support;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Pages\Partials\ButtonPartial.cshtml"
    using Newtonsoft.Json;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Pages\Partials\ButtonPartial.cshtml"
    using Newtonsoft.Json.Converters;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class ButtonPartial : Hangfire.Dashboard.RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");








            
            #line 8 "..\..\Pages\Partials\ButtonPartial.cshtml"
  
	var url = $"{ManagementPage.UrlRoute}/{Job.JobId.ScrubURL()}";
	var loadingText = "Queuing";

	var timeSpanItems = new Dictionary<string, string>() {
		{ "5 seconds", "0:0:5" },
		{ "10 seconds", "0:0:10" },
		{ "15 seconds", "0:0:15" },
		{ "30 seconds", "0:0:30" },
		{ "60 seconds", "0:1:0" }
	};

	var cronItems = new Dictionary<string, string>() {
		{ "Every Minute", Cron.Minutely() },
		{ "Hourly", Cron.Hourly() },
		{ "Daily", Cron.Daily() },
		{ "Weekly", Cron.Weekly() },
		{ "Monthly", Cron.Monthly() },
		{ "Annually", Cron.Yearly() }
	};


            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"btn-group col-xs-12 col-sm-3\">\r\n\t<button class=\"btn btn-default dro" +
"pdown-toggle\" type=\"button\" id=\"dropdownMenu1\" data-toggle=\"dropdown\" aria-haspo" +
"pup=\"true\" aria-expanded=\"false\">\r\n\t\tTask type: <span class=\"");


            
            #line 32 "..\..\Pages\Partials\ButtonPartial.cshtml"
                     Write(JobId);

            
            #line default
            #line hidden
WriteLiteral(" commandsType\">Immediate</span>\r\n\t\t<span class=\"caret\"></span>\r\n\t</button>\r\n\t<ul " +
"class=\"dropdown-menu\" aria-labelledby=\"dropdownMenu1\">\r\n\t\t<li><a class=\"commands" +
"-type\" data-commands-type=\"Enqueue\" data-id=\"");


            
            #line 36 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                Write(JobId);

            
            #line default
            #line hidden
WriteLiteral("\">Immediate</a></li>\r\n\t\t<li><a class=\"commands-type\" data-commands-type=\"Schedule" +
"DateTime\" data-id=\"");


            
            #line 37 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                         Write(JobId);

            
            #line default
            #line hidden
WriteLiteral("\">Scheduled</a></li>\r\n\t\t<li><a class=\"commands-type\" data-commands-type=\"Schedule" +
"TimeSpan\" data-id=\"");


            
            #line 38 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                         Write(JobId);

            
            #line default
            #line hidden
WriteLiteral("\">Delayed</a></li>\r\n\t\t<li><a class=\"commands-type\" data-commands-type=\"CronExpres" +
"sion\" data-id=\"");


            
            #line 39 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                       Write(JobId);

            
            #line default
            #line hidden
WriteLiteral(@""">Repeating</a></li>
	</ul>
</div>
<!-- Immediate Command -->
<div class=""commands-options Enqueue col-xs-12 col-sm-6"">
    <label class=""control-label"">Queue Name:</label>
    <input type='text' class=""form-control hdm-execution-input"" placeholder=""QueueName"" id=""");


            
            #line 45 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                                        Write($"{JobId}_queuename");

            
            #line default
            #line hidden
WriteLiteral("\" value=\"");


            
            #line 45 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                                                                       Write(Job.Queue);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n</div>\r\n\r\n<div class=\"commands-panel col-xs-12 Enqueue col-sm-3\">\r\n\t<button" +
" class=\"hdm-management-input-commands btn btn-sm btn-success\" data-url=\"");


            
            #line 49 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                           Write(Url.To(url));

            
            #line default
            #line hidden
WriteLiteral("\" data-loading-text=\"");


            
            #line 49 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                                                            Write(loadingText);

            
            #line default
            #line hidden
WriteLiteral("\" input-id=\"");


            
            #line 49 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                                                                                    Write(JobId);

            
            #line default
            #line hidden
WriteLiteral(@""" input-type=""Enqueue"">
		<span class=""glyphicon glyphicon-play-circle""></span>
		Queue Execution
	</button>
</div>
<!-- Schedule DateTime Command-->
<div class=""commands-options ScheduleDateTime col-xs-12 col-sm-6 hide"">
	<div class='hdm-execution-input input-group date' id=""");


            
            #line 56 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                   Write($"{JobId}_datetimepicker");

            
            #line default
            #line hidden
WriteLiteral("\" data-td_options=\"");


            
            #line 56 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                                                 Write(JsonConvert.SerializeObject(JsonConvert.DeserializeObject(JobsHelper.ClientSideConfigurationOptions.DateTimeOpts.ScheduleButtonOptions), Formatting.None));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n\t\t<input type=\'text\' class=\"form-control\" placeholder=\"Enter a Date\" id=\"");


            
            #line 57 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                     Write($"{JobId}_sys_datetime");

            
            #line default
            #line hidden
WriteLiteral(@""" />
		<span class=""input-group-addon"">
			<span class=""glyphicon glyphicon-calendar""></span>
		</span>
	</div>
</div>
<div class=""commands-panel ScheduleDateTime col-xs-12 col-sm-3 hide"">
	<button class=""btn btn-default btn-sm btn-primary hdm-management-input-commands"" type=""button"" input-id=""");


            
            #line 64 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                                                     Write(JobId);

            
            #line default
            #line hidden
WriteLiteral("\" input-type=\"ScheduleDateTime\" data-url=\"");


            
            #line 64 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                                                                                                     Write(Url.To(url));

            
            #line default
            #line hidden
WriteLiteral("\" data-loading-text=\"");


            
            #line 64 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                                                                                                                                      Write(loadingText);

            
            #line default
            #line hidden
WriteLiteral(@""">
		<span class=""glyphicon glyphicon-calendar""></span>
		Schedule Execution
	</button>
</div>


<!-- Schedule Timespan Command -->
<div class=""commands-options ScheduleTimeSpan col-xs-12 col-sm-6 hide"">
	<input type=""text"" class=""hdm-execution-input form-control time"" placeholder=""HH:mm:ss"" id=""");


            
            #line 73 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                                         Write($"{JobId}_sys_timespan");

            
            #line default
            #line hidden
WriteLiteral("\" data-inputmask=\"\'mask\' :\'99:99:99\'\">\r\n</div>\r\n<div class=\"commands-panel Schedu" +
"leTimeSpan col-xs-12 col-sm-3 hide\">\r\n\t<div class=\"btn-group\">\r\n\t\t<button class=" +
"\"btn btn-default btn-sm btn-info hdm-management-input-commands\" type=\"button\" in" +
"put-id=\"");


            
            #line 77 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                                                   Write(JobId);

            
            #line default
            #line hidden
WriteLiteral("\" input-type=\"ScheduleTimeSpan\" data-url=\"");


            
            #line 77 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                                                                                                   Write(Url.To(url));

            
            #line default
            #line hidden
WriteLiteral("\" data-loading-text=\"");


            
            #line 77 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                                                                                                                                    Write(loadingText);

            
            #line default
            #line hidden
WriteLiteral(@""">
			<span class=""glyphicon glyphicon-time""></span>
			Delayed Execution
		</button>
		<button type=""button"" class=""btn btn-info btn-sm dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
			<span class=""caret""></span>
		</button>
		<ul class=""dropdown-menu dropdown-menu-right"">
");


            
            #line 85 "..\..\Pages\Partials\ButtonPartial.cshtml"
 			foreach (var o in timeSpanItems)
			{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<li>\r\n\t\t\t\t\t<a class=\"hdm-management-input-commands text-center\" input-id=\"");


            
            #line 88 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                               Write(JobId);

            
            #line default
            #line hidden
WriteLiteral("\" input-type=\"ScheduleTimeSpan\" data-schedule=\"");


            
            #line 88 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                                                                    Write(o.Value);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n\t\t\t\t\t   data-url=\"");


            
            #line 89 "..\..\Pages\Partials\ButtonPartial.cshtml"
             Write(Url.To(url));

            
            #line default
            #line hidden
WriteLiteral("\" data-loading-text=\"");


            
            #line 89 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                              Write(loadingText);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 89 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                            Write(o.Key);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n\t\t\t\t</li>\r\n");


            
            #line 91 "..\..\Pages\Partials\ButtonPartial.cshtml"
			}

            
            #line default
            #line hidden
WriteLiteral("\t\t</ul>\r\n\t</div>\r\n</div>\r\n\r\n<!-- Cron Expression Command -->\r\n<div class=\"command" +
"s-options CronExpression col-xs-12 col-sm-5 hide\">\r\n\t<input class=\"form-control " +
"hdm-execution-input-exp\" title=\"Enter a cron expression\" id=\"");


            
            #line 98 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                                     Write($"{JobId}_sys_cron");

            
            #line default
            #line hidden
WriteLiteral("\" placeholder=\"* 1 * * *\" value=\"\" />\r\n</div>\r\n");


            
            #line 100 "..\..\Pages\Partials\ButtonPartial.cshtml"
 if (Job.AllowMultiple)
{

            
            #line default
            #line hidden
WriteLiteral("\t<div class=\"commands-options CronExpression col-xs-12 col-sm-4 hide\">\r\n\t\t<div cl" +
"ass=\"input-group\" id=\"");


            
            #line 103 "..\..\Pages\Partials\ButtonPartial.cshtml"
                           Write($"{JobId}_Name");

            
            #line default
            #line hidden
WriteLiteral("\">\r\n\t\t\t<input type=\"text\" class=\"hdm-execution-input-name form-control\" title=\"\" " +
"placeholder=\"Job Name\" id=\"");


            
            #line 104 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                                                    Write($"{JobId}_sys_name");

            
            #line default
            #line hidden
WriteLiteral("\" data-original-title=\"Give a unique name to your job\" spellcheck=\"false\" data-ms" +
"-editor=\"true\">\r\n\t\t</div>\r\n\t</div>\r\n");


            
            #line 107 "..\..\Pages\Partials\ButtonPartial.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"commands-panel CronExpression col-xs-12 col-sm-4 hide\">\r\n\t<div clas" +
"s=\"btn-group\">\r\n\t\t<button class=\"btn btn-default btn-sm btn-warning hdm-manageme" +
"nt-input-commands\" type=\"button\" input-id=\"");


            
            #line 111 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                                                      Write(JobId);

            
            #line default
            #line hidden
WriteLiteral("\" input-type=\"CronExpression\"\r\n\t\t\t\tdata-confirm=\"If this job already has a schedu" +
"le then it will be updated. Continue?\" data-url=\"");


            
            #line 112 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                                              Write(Url.To(url));

            
            #line default
            #line hidden
WriteLiteral("\" data-loading-text=\"");


            
            #line 112 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                                                                               Write(loadingText);

            
            #line default
            #line hidden
WriteLiteral(@""">
			<span class=""glyphicon glyphicon-repeat""></span>
			Recurring Execution
		</button>
		<button type=""button"" class=""btn btn-warning btn-sm dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
			<span class=""caret""></span>
		</button>
		<ul class=""dropdown-menu dropdown-menu-right"">
");


            
            #line 120 "..\..\Pages\Partials\ButtonPartial.cshtml"
 			foreach (var o in cronItems)
			{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<li>\r\n\t\t\t\t\t<a class=\"hdm-management-input-commands text-right\" input-id=\"");


            
            #line 123 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                              Write(JobId);

            
            #line default
            #line hidden
WriteLiteral("\" input-type=\"CronExpression\" data-schedule=\"");


            
            #line 123 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                                                                 Write(o.Value);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n\t\t\t\t\t\tdata-confirm=\"If this job already has a schedule then it will be updated" +
".  Continue?\" data-url=\"");


            
            #line 124 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                                                 Write(Url.To(url));

            
            #line default
            #line hidden
WriteLiteral("\" data-loading-text=\"");


            
            #line 124 "..\..\Pages\Partials\ButtonPartial.cshtml"
                                                                                                                                  Write(loadingText);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n\t\t\t\t\t\t");


            
            #line 125 "..\..\Pages\Partials\ButtonPartial.cshtml"
 Write(o.Key);

            
            #line default
            #line hidden
WriteLiteral(": <span>(");


            
            #line 125 "..\..\Pages\Partials\ButtonPartial.cshtml"
                Write(o.Value);

            
            #line default
            #line hidden
WriteLiteral(")</span>\r\n\t\t\t\t\t</a>\r\n\t\t\t\t</li>\r\n");


            
            #line 128 "..\..\Pages\Partials\ButtonPartial.cshtml"
			}

            
            #line default
            #line hidden
WriteLiteral("\t\t</ul>\r\n\t</div>\r\n</div>");


        }
    }
}
#pragma warning restore 1591
