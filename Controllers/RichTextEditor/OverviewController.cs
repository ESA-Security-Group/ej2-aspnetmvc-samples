﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class RichTextEditorController : Controller
    {
        public ActionResult Overview()
        {
            ViewBag.value = @"<p>The rich text editor is WYSIWYG ('what you see is what you get') editor useful to create and edit content, and return the valid <a href='https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/formation/?no-cache=1#markdown-editor'>HTML markup</a> or <a href='https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/formation/?no-cache=1#html-editor'>markdown</a> of the content</p>
                                    <p><b> Toolbar </b></p>
                                    <ol>          
                                        <li>          
                                            <p>Toolbar contains commands to align the text, insert link, insert image, insert list, undo / redo operations, HTML view, etc </p>          
                                        </li>
                                        <li>
                                            <p>Toolbar is fully customizable </p>
                                        </li>
                                    </ol>
                                    <p><b> Links </b></p>
                                    <ol>
                                        <li>
                                            <p>You can insert a hyperlink with its corresponding dialog</p>
                                        </li>
                                        <li>
                                            <p>Attach a hyperlink to the displayed text. </p>
                                        </li>
                                        <li>
                                            <p>Customize the quick toolbar based on the hyperlink </p>
                                        </li>
                                    </ol>
                                    <p><b> Image.</b></p>
                                    <ol>
                                        <li>
                                            <p>Allows you to insert images from an online source as well as the local computer</p>
                                        </li>
                                        <li>
                                            <p>You can upload an image</p>
                                        </li>
                                        <li>
                                            <p>Provides an option to customize quick toolbar for an image </p>
                                        </li>
                                    </ol>
                                    <img alt = 'Logo' src ="+ @Url.Content("~/Content/images/RichTextEditor/RTEImage-Feather.png") + " style='width: 300px'/></div></div></div>";


            ViewBag.tools = new[] { "Bold", "Italic", "Underline", "StrikeThrough",
                            "FontName", "FontSize", "FontColor", "BackgroundColor",
                            "LowerCase", "UpperCase", "|",
                            "Formats", "Alignments", "OrderedList", "UnorderedList",
                            "Outdent", "Indent", "|",
                            "CreateTable", "CreateLink", "Image", "|", "ClearFormat", "Print",
                            "SourceCode", "FullScreen", "|", "Undo", "Redo" };

            return View();
        }
    }
}
