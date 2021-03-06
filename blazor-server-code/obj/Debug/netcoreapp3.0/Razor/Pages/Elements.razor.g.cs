#pragma checksum "C:\Users\James.INnes\source\repos\my-website\blazor-server-code\Pages\Elements.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d4203f8b8d07c7327f30d418691c852e4de300e"
// <auto-generated/>
#pragma warning disable 1591
namespace Website.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\James.INnes\source\repos\my-website\blazor-server-code\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\James.INnes\source\repos\my-website\blazor-server-code\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\James.INnes\source\repos\my-website\blazor-server-code\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\James.INnes\source\repos\my-website\blazor-server-code\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\James.INnes\source\repos\my-website\blazor-server-code\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\James.INnes\source\repos\my-website\blazor-server-code\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\James.INnes\source\repos\my-website\blazor-server-code\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\James.INnes\source\repos\my-website\blazor-server-code\_Imports.razor"
using Website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\James.INnes\source\repos\my-website\blazor-server-code\_Imports.razor"
using Website.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/elements")]
    public partial class Elements : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n\t");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "id", "top");
            __builder.AddAttribute(5, "class", "page");
            __builder.AddAttribute(6, "role", "document");
            __builder.AddMarkupContent(7, "\r\n\t\t");
            __builder.AddMarkupContent(8, "<nav role=\"navigation\">\r\n\t\t\t<ul>\r\n\t\t\t\t<li>\r\n\t\t\t\t\t<a href=\"#text\">Text</a>\r\n\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t<li><a href=\"#text__headings\">Headings</a></li>\r\n\t\t\t\t\t\t<li><a href=\"#text__paragraphs\">Paragraphs</a></li>\r\n\t\t\t\t\t\t<li><a href=\"#text__blockquotes\">Blockquotes</a></li>\r\n\t\t\t\t\t\t<li><a href=\"#text__lists\">Lists</a></li>\r\n\t\t\t\t\t\t<li><a href=\"#text__hr\">Horizontal rules</a></li>\r\n\t\t\t\t\t\t<li><a href=\"#text__tables\">Tabular data</a></li>\r\n\t\t\t\t\t\t<li><a href=\"#text__code\">Code</a></li>\r\n\t\t\t\t\t\t<li><a href=\"#text__inline\">Inline elements</a></li>\r\n\t\t\t\t\t\t<li><a href=\"#text__comments\">HTML Comments</a></li>\r\n\t\t\t\t\t</ul>\r\n\t\t\t\t</li>\r\n\t\t\t\t<li>\r\n\t\t\t\t\t<a href=\"#embedded\">Embedded content</a>\r\n\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t<li><a href=\"#embedded__images\">Images</a></li>\r\n\t\t\t\t\t\t<li><a href=\"#embedded__audio\">Audio</a></li>\r\n\t\t\t\t\t\t<li><a href=\"#embedded__video\">Video</a></li>\r\n\t\t\t\t\t\t<li><a href=\"#embedded__canvas\">Canvas</a></li>\r\n\t\t\t\t\t\t<li><a href=\"#embedded__meter\">Meter</a></li>\r\n\t\t\t\t\t\t<li><a href=\"#embedded__progress\">Progress</a></li>\r\n\t\t\t\t\t\t<li><a href=\"#embedded__svg\">Inline SVG</a></li>\r\n\t\t\t\t\t\t<li><a href=\"#embedded__iframe\">IFrames</a></li>\r\n\t\t\t\t\t</ul>\r\n\t\t\t\t</li>\r\n\t\t\t\t<li>\r\n\t\t\t\t\t<a href=\"#forms\">Form elements</a>\r\n\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t<li><a href=\"#forms__input\">Input fields</a></li>\r\n\t\t\t\t\t\t<li><a href=\"#forms__select\">Select menus</a></li>\r\n\t\t\t\t\t\t<li><a href=\"#forms__checkbox\">Checkboxes</a></li>\r\n\t\t\t\t\t\t<li><a href=\"#forms__radio\">Radio buttons</a></li>\r\n\t\t\t\t\t\t<li><a href=\"#forms__textareas\">Textareas</a></li>\r\n\t\t\t\t\t\t<li><a href=\"#forms__html5\">HTML5 inputs</a></li>\r\n\t\t\t\t\t\t<li><a href=\"#forms__action\">Action buttons</a></li>\r\n\t\t\t\t\t</ul>\r\n\t\t\t\t</li>\r\n\t\t\t</ul>\r\n\t\t</nav>\r\n\r\n\t\t");
            __builder.AddMarkupContent(9, "<section id=\"text\">\r\n\t\t\t<header><h1>Text</h1></header>\r\n\t\t\t<article id=\"text__headings\">\r\n\t\t\t\t<header>\r\n\t\t\t\t\t<h1>Headings</h1>\r\n\t\t\t\t</header>\r\n\t\t\t\t<div>\r\n\t\t\t\t\t<h1>Heading 1</h1>\r\n\t\t\t\t\t<h2>Heading 2</h2>\r\n\t\t\t\t\t<h3>Heading 3</h3>\r\n\t\t\t\t\t<h4>Heading 4</h4>\r\n\t\t\t\t\t<h5>Heading 5</h5>\r\n\t\t\t\t\t<h6>Heading 6</h6>\r\n\t\t\t\t</div>\r\n\t\t\t\t<footer><p><a href=\"#top\">[Top]</a></p></footer>\r\n\t\t\t</article>\r\n\t\t\t<article id=\"text__paragraphs\">\r\n\t\t\t\t<header><h1>Paragraphs</h1></header>\r\n\t\t\t\t<div>\r\n\t\t\t\t\t<p>A paragraph (from the Greek paragraphos, ???to write beside??? or ???written beside???) is a self-contained unit of a discourse in writing dealing with a particular point or idea. A paragraph consists of one or more sentences. Though not required by the syntax of any language, paragraphs are usually an expected part of formal writing, used to organize longer prose.</p>\r\n\t\t\t\t</div>\r\n\t\t\t\t<footer><p><a href=\"#top\">[Top]</a></p></footer>\r\n\t\t\t</article>\r\n\t\t\t<article id=\"text__blockquotes\">\r\n\t\t\t\t<header><h1>Blockquotes</h1></header>\r\n\t\t\t\t<div>\r\n\t\t\t\t\t<blockquote>\r\n\t\t\t\t\t\t<p>A block quotation (also known as a long quotation or extract) is a quotation in a written document, that is set off from the main text as a paragraph, or block of text.</p>\r\n\t\t\t\t\t\t<p>It is typically distinguished visually using indentation and a different typeface or smaller size quotation. It may or may not include a citation, usually placed at the bottom.</p>\r\n\t\t\t\t\t\t<cite><a href=\"#!\">Said no one, ever.</a></cite>\r\n\t\t\t\t\t</blockquote>\r\n\t\t\t\t</div>\r\n\t\t\t\t<footer><p><a href=\"#top\">[Top]</a></p></footer>\r\n\t\t\t</article>\r\n\t\t\t<article id=\"text__lists\">\r\n\t\t\t\t<header><h1>Lists</h1></header>\r\n\t\t\t\t<div>\r\n\t\t\t\t\t<h3>Definition list</h3>\r\n\t\t\t\t\t<dl>\r\n\t\t\t\t\t\t<dt>Definition List Title</dt>\r\n\t\t\t\t\t\t<dd>This is a definition list division.</dd>\r\n\t\t\t\t\t</dl>\r\n\t\t\t\t\t<h3>Ordered List</h3>\r\n\t\t\t\t\t<ol>\r\n\t\t\t\t\t\t<li>List Item 1</li>\r\n\t\t\t\t\t\t<li>List Item 2</li>\r\n\t\t\t\t\t\t<li>List Item 3</li>\r\n\t\t\t\t\t</ol>\r\n\t\t\t\t\t<h3>Unordered List</h3>\r\n\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t<li>List Item 1</li>\r\n\t\t\t\t\t\t<li>List Item 2</li>\r\n\t\t\t\t\t\t<li>List Item 3</li>\r\n\t\t\t\t\t</ul>\r\n\t\t\t\t</div>\r\n\t\t\t\t<footer><p><a href=\"#top\">[Top]</a></p></footer>\r\n\t\t\t</article>\r\n\t\t\t<article id=\"text__hr\">\r\n\t\t\t\t<header><h1>Horizontal rules</h1></header>\r\n\t\t\t\t<div>\r\n\t\t\t\t\t<hr>\r\n\t\t\t\t</div>\r\n\t\t\t\t<footer><p><a href=\"#top\">[Top]</a></p></footer>\r\n\t\t\t</article>\r\n\t\t\t<article id=\"text__tables\">\r\n\t\t\t\t<header><h1>Tabular data</h1></header>\r\n\t\t\t\t<table>\r\n\t\t\t\t\t<caption>Table Caption</caption>\r\n\t\t\t\t\t<thead>\r\n\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t<th>Table Heading 1</th>\r\n\t\t\t\t\t\t\t<th>Table Heading 2</th>\r\n\t\t\t\t\t\t\t<th>Table Heading 3</th>\r\n\t\t\t\t\t\t\t<th>Table Heading 4</th>\r\n\t\t\t\t\t\t\t<th>Table Heading 5</th>\r\n\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t</thead>\r\n\t\t\t\t\t<tfoot>\r\n\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t<th>Table Footer 1</th>\r\n\t\t\t\t\t\t\t<th>Table Footer 2</th>\r\n\t\t\t\t\t\t\t<th>Table Footer 3</th>\r\n\t\t\t\t\t\t\t<th>Table Footer 4</th>\r\n\t\t\t\t\t\t\t<th>Table Footer 5</th>\r\n\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t</tfoot>\r\n\t\t\t\t\t<tbody>\r\n\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t<td>Table Cell 1</td>\r\n\t\t\t\t\t\t\t<td>Table Cell 2</td>\r\n\t\t\t\t\t\t\t<td>Table Cell 3</td>\r\n\t\t\t\t\t\t\t<td>Table Cell 4</td>\r\n\t\t\t\t\t\t\t<td>Table Cell 5</td>\r\n\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t<td>Table Cell 1</td>\r\n\t\t\t\t\t\t\t<td>Table Cell 2</td>\r\n\t\t\t\t\t\t\t<td>Table Cell 3</td>\r\n\t\t\t\t\t\t\t<td>Table Cell 4</td>\r\n\t\t\t\t\t\t\t<td>Table Cell 5</td>\r\n\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t<td>Table Cell 1</td>\r\n\t\t\t\t\t\t\t<td>Table Cell 2</td>\r\n\t\t\t\t\t\t\t<td>Table Cell 3</td>\r\n\t\t\t\t\t\t\t<td>Table Cell 4</td>\r\n\t\t\t\t\t\t\t<td>Table Cell 5</td>\r\n\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t<td>Table Cell 1</td>\r\n\t\t\t\t\t\t\t<td>Table Cell 2</td>\r\n\t\t\t\t\t\t\t<td>Table Cell 3</td>\r\n\t\t\t\t\t\t\t<td>Table Cell 4</td>\r\n\t\t\t\t\t\t\t<td>Table Cell 5</td>\r\n\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t</tbody>\r\n\t\t\t\t</table>\r\n\t\t\t\t<footer><p><a href=\"#top\">[Top]</a></p></footer>\r\n\t\t\t</article>\r\n\t\t\t<article id=\"text__code\">\r\n\t\t\t\t<header><h1>Code</h1></header>\r\n\t\t\t\t<div>\r\n\t\t\t\t\t<p><strong>Keyboard input:</strong> <kbd>Cmd</kbd></p>\r\n\t\t\t\t\t<p><strong>Inline code:</strong> <code>&lt;div&gt;code&lt;/div&gt;</code></p>\r\n\t\t\t\t\t<p><strong>Sample output:</strong> <samp>This is sample output from a computer program.</samp></p>\r\n\t\t\t\t\t<h2>Pre-formatted text</h2>\r\n\t\t\t\t\t<pre>P R E F O R M A T T E D T E X T\r\n  ! \" # $ % &amp; \' ( ) * + , - . /\r\n  0 1 2 3 4 5 6 7 8 9 : ; &lt; = &gt; ?\r\n  x A B C D E F G H I J K L M N O\r\n  P Q R S T U V W X Y Z [ \\ ] ^ _\r\n  ` a b c d e f g h i j k l m n o\r\n  p q r s t u v w x y z { | } ~ </pre>\r\n\t\t\t\t</div>\r\n\t\t\t\t<footer><p><a href=\"#top\">[Top]</a></p></footer>\r\n\t\t\t</article>\r\n\t\t\t<article id=\"text__inline\">\r\n\t\t\t\t<header><h1>Inline elements</h1></header>\r\n\t\t\t\t<div>\r\n\t\t\t\t\t<p><a href=\"#!\">This is a text link</a>.</p>\r\n\t\t\t\t\t<p><strong>Strong is used to indicate strong importance.</strong></p>\r\n\t\t\t\t\t<p><em>This text has added emphasis.</em></p>\r\n\t\t\t\t\t<p>The <b>b element</b> is stylistically different text from normal text, without any special importance.</p>\r\n\t\t\t\t\t<p>The <i>i element</i> is text that is offset from the normal text.</p>\r\n\t\t\t\t\t<p>The <u>u element</u> is text with an unarticulated, though explicitly rendered, non-textual annotation.</p>\r\n\t\t\t\t\t<p><del>This text is deleted</del> and <ins>This text is inserted</ins>.</p>\r\n\t\t\t\t\t<p><s>This text has a strikethrough</s>.</p>\r\n\t\t\t\t\t<p>Superscript<sup>??</sup>.</p>\r\n\t\t\t\t\t<p>Subscript for things like H<sub>2</sub>O.</p>\r\n\t\t\t\t\t<p><small>This small text is small for for fine print, etc.</small></p>\r\n\t\t\t\t\t<p>Abbreviation: <abbr title=\"HyperText Markup Language\">HTML</abbr></p>\r\n\t\t\t\t\t<p><q cite=\"https://developer.mozilla.org/en-US/docs/HTML/Element/q\">This text is a short inline quotation.</q></p>\r\n\t\t\t\t\t<p><cite>This is a citation.</cite></p>\r\n\t\t\t\t\t<p>The <dfn>dfn element</dfn> indicates a definition.</p>\r\n\t\t\t\t\t<p>The <mark>mark element</mark> indicates a highlight.</p>\r\n\t\t\t\t\t<p>The <var>variable element</var>, such as <var>x</var> = <var>y</var>.</p>\r\n\t\t\t\t\t<p>The time element: <time datetime=\"2013-04-06T12:32+00:00\">2 weeks ago</time></p>\r\n\t\t\t\t</div>\r\n\t\t\t\t<footer><p><a href=\"#top\">[Top]</a></p></footer>\r\n\t\t\t</article>\r\n\t\t\t<article id=\"text__comments\">\r\n\t\t\t\t<header><h1>HTML Comments</h1></header>\r\n\t\t\t\t<div>\r\n\t\t\t\t\t<p>There is comment here: </p>\r\n\t\t\t\t\t<p>There is a comment spanning multiple tags and lines below here.</p>\r\n\t\t\t\t\t\r\n\t\t\t\t</div>\r\n\t\t\t\t<footer><p><a href=\"#top\">[Top]</a></p></footer>\r\n\t\t\t</article>\r\n\t\t</section>\r\n\t\t");
            __builder.AddMarkupContent(10, "<section id=\"embedded\">\r\n\t\t\t<header><h1>Embedded content</h1></header>\r\n\t\t\t<article id=\"embedded__images\">\r\n\t\t\t\t<header><h2>Images</h2></header>\r\n\t\t\t\t<div>\r\n\t\t\t\t\t<h3>No <code>&lt;figure&gt;</code> element</h3>\r\n\t\t\t\t\t<p><img src=\"http://placekitten.com/480/480\" alt=\"Image alt text\"></p>\r\n\t\t\t\t\t<h3>Wrapped in a <code>&lt;figure&gt;</code> element, no <code>&lt;figcaption&gt;</code></h3>\r\n\t\t\t\t\t<figure><img src=\"http://placekitten.com/420/420\" alt=\"Image alt text\"></figure>\r\n\t\t\t\t\t<h3>Wrapped in a <code>&lt;figure&gt;</code> element, with a <code>&lt;figcaption&gt;</code></h3>\r\n\t\t\t\t\t<figure>\r\n\t\t\t\t\t\t<img src=\"http://placekitten.com/420/420\" alt=\"Image alt text\">\r\n\t\t\t\t\t\t<figcaption>Here is a caption for this image.</figcaption>\r\n\t\t\t\t\t</figure>\r\n\t\t\t\t</div>\r\n\t\t\t\t<footer><p><a href=\"#top\">[Top]</a></p></footer>\r\n\t\t\t</article>\r\n\t\t\t<article id=\"embedded__audio\">\r\n\t\t\t\t<header><h2>Audio</h2></header>\r\n\t\t\t\t<div><audio controls>audio</audio></div>\r\n\t\t\t\t<footer><p><a href=\"#top\">[Top]</a></p></footer>\r\n\t\t\t</article>\r\n\t\t\t<article id=\"embedded__video\">\r\n\t\t\t\t<header><h2>Video</h2></header>\r\n\t\t\t\t<div><video controls>video</video></div>\r\n\t\t\t\t<footer><p><a href=\"#top\">[Top]</a></p></footer>\r\n\t\t\t</article>\r\n\t\t\t<article id=\"embedded__canvas\">\r\n\t\t\t\t<header><h2>Canvas</h2></header>\r\n\t\t\t\t<div><canvas>canvas</canvas></div>\r\n\t\t\t\t<footer><p><a href=\"#top\">[Top]</a></p></footer>\r\n\t\t\t</article>\r\n\t\t\t<article id=\"embedded__meter\">\r\n\t\t\t\t<header><h2>Meter</h2></header>\r\n\t\t\t\t<div><meter value=\"2\" min=\"0\" max=\"10\">2 out of 10</meter></div>\r\n\t\t\t\t<footer><p><a href=\"#top\">[Top]</a></p></footer>\r\n\t\t\t</article>\r\n\t\t\t<article id=\"embedded__progress\">\r\n\t\t\t\t<header><h2>Progress</h2></header>\r\n\t\t\t\t<div><progress>progress</progress></div>\r\n\t\t\t\t<footer><p><a href=\"#top\">[Top]</a></p></footer>\r\n\t\t\t</article>\r\n\t\t\t<article id=\"embedded__svg\">\r\n\t\t\t\t<header><h2>Inline SVG</h2></header>\r\n\t\t\t\t<div><svg width=\"100px\" height=\"100px\"><circle cx=\"100\" cy=\"100\" r=\"100\" fill=\"#1fa3ec\"></circle></svg></div>\r\n\t\t\t\t<footer><p><a href=\"#top\">[Top]</a></p></footer>\r\n\t\t\t</article>\r\n\t\t\t<article id=\"embedded__iframe\">\r\n\t\t\t\t<header><h2>IFrame</h2></header>\r\n\t\t\t\t<div><iframe src=\"index.html\" height=\"300\"></iframe></div>\r\n\t\t\t\t<footer><p><a href=\"#top\">[Top]</a></p></footer>\r\n\t\t\t</article>\r\n\t\t</section>\r\n\t\t");
            __builder.OpenElement(11, "section");
            __builder.AddAttribute(12, "id", "forms");
            __builder.AddMarkupContent(13, "\r\n\t\t\t");
            __builder.AddMarkupContent(14, "<header><h1>Form elements</h1></header>\r\n\t\t\t");
            __builder.OpenElement(15, "form");
            __builder.AddMarkupContent(16, "\r\n\t\t\t\t");
            __builder.AddMarkupContent(17, "<fieldset id=\"forms__input\">\r\n\t\t\t\t\t<legend>Input fields</legend>\r\n\t\t\t\t\t<p>\r\n\t\t\t\t\t\t<label for=\"input__text\">Text Input</label>\r\n\t\t\t\t\t\t<input id=\"input__text\" type=\"text\" placeholder=\"Text Input\">\r\n\t\t\t\t\t</p>\r\n\t\t\t\t\t<p>\r\n\t\t\t\t\t\t<label for=\"input__password\">Password</label>\r\n\t\t\t\t\t\t<input id=\"input__password\" type=\"password\" placeholder=\"Type your Password\">\r\n\t\t\t\t\t</p>\r\n\t\t\t\t\t<p>\r\n\t\t\t\t\t\t<label for=\"input__webaddress\">Web Address</label>\r\n\t\t\t\t\t\t<input id=\"input__webaddress\" type=\"url\" placeholder=\"http://yoursite.com\">\r\n\t\t\t\t\t</p>\r\n\t\t\t\t\t<p>\r\n\t\t\t\t\t\t<label for=\"input__emailaddress\">Email Address</label>\r\n\t\t\t\t\t\t<input id=\"input__emailaddress\" type=\"email\" placeholder=\"name@email.com\">\r\n\t\t\t\t\t</p>\r\n\t\t\t\t\t<p>\r\n\t\t\t\t\t\t<label for=\"input__phone\">Phone Number</label>\r\n\t\t\t\t\t\t<input id=\"input__phone\" type=\"tel\" placeholder=\"(999) 999-9999\">\r\n\t\t\t\t\t</p>\r\n\t\t\t\t\t<p>\r\n\t\t\t\t\t\t<label for=\"input__search\">Search</label>\r\n\t\t\t\t\t\t<input id=\"input__search\" type=\"search\" placeholder=\"Enter Search Term\">\r\n\t\t\t\t\t</p>\r\n\t\t\t\t\t<p>\r\n\t\t\t\t\t\t<label for=\"input__text2\">Number Input</label>\r\n\t\t\t\t\t\t<input id=\"input__text2\" type=\"number\" placeholder=\"Enter a Number\">\r\n\t\t\t\t\t</p>\r\n\t\t\t\t\t<p>\r\n\t\t\t\t\t\t<label for=\"input__text3\" class=\"error\">Error</label>\r\n\t\t\t\t\t\t<input id=\"input__text3\" class=\"is-error\" type=\"text\" placeholder=\"Text Input\">\r\n\t\t\t\t\t</p>\r\n\t\t\t\t\t<p>\r\n\t\t\t\t\t\t<label for=\"input__text4\" class=\"valid\">Valid</label>\r\n\t\t\t\t\t\t<input id=\"input__text4\" class=\"is-valid\" type=\"text\" placeholder=\"Text Input\">\r\n\t\t\t\t\t</p>\r\n\t\t\t\t</fieldset>\r\n\t\t\t\t");
            __builder.AddMarkupContent(18, "<p><a href=\"#top\">[Top]</a></p>\r\n\t\t\t\t");
            __builder.OpenElement(19, "fieldset");
            __builder.AddAttribute(20, "id", "forms__select");
            __builder.AddMarkupContent(21, "\r\n\t\t\t\t\t");
            __builder.AddMarkupContent(22, "<legend>Select menus</legend>\r\n\t\t\t\t\t");
            __builder.OpenElement(23, "p");
            __builder.AddMarkupContent(24, "\r\n\t\t\t\t\t\t");
            __builder.AddMarkupContent(25, "<label for=\"select\">Select</label>\r\n\t\t\t\t\t\t");
            __builder.OpenElement(26, "select");
            __builder.AddAttribute(27, "id", "select");
            __builder.AddMarkupContent(28, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(29, "optgroup");
            __builder.AddAttribute(30, "label", "Option Group");
            __builder.AddMarkupContent(31, "\r\n\t\t\t\t\t\t\t\t");
            __builder.OpenElement(32, "option");
            __builder.AddContent(33, "Option One");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\t\t\t\t\t\t\t\t");
            __builder.OpenElement(35, "option");
            __builder.AddContent(36, "Option Two");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\t\t\t\t\t\t\t\t");
            __builder.OpenElement(38, "option");
            __builder.AddContent(39, "Option Three");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\t\t\t\t");
            __builder.AddMarkupContent(45, "<p><a href=\"#top\">[Top]</a></p>\r\n\t\t\t\t");
            __builder.AddMarkupContent(46, @"<fieldset id=""forms__checkbox"">
					<legend>Checkboxes</legend>
					<ul class=""list list--bare"">
						<li><label for=""checkbox1""><input id=""checkbox1"" name=""checkbox"" type=""checkbox"" checked=""checked""> Choice A</label></li>
						<li><label for=""checkbox2""><input id=""checkbox2"" name=""checkbox"" type=""checkbox""> Choice B</label></li>
						<li><label for=""checkbox3""><input id=""checkbox3"" name=""checkbox"" type=""checkbox""> Choice C</label></li>
					</ul>
				</fieldset>
				");
            __builder.AddMarkupContent(47, "<p><a href=\"#top\">[Top]</a></p>\r\n\t\t\t\t");
            __builder.AddMarkupContent(48, @"<fieldset id=""forms__radio"">
					<legend>Radio buttons</legend>
					<ul class=""list list--bare"">
						<li><label for=""radio1""><input id=""radio1"" name=""radio"" type=""radio"" class=""radio"" checked=""checked""> Option 1</label></li>
						<li><label for=""radio2""><input id=""radio2"" name=""radio"" type=""radio"" class=""radio""> Option 2</label></li>
						<li><label for=""radio3""><input id=""radio3"" name=""radio"" type=""radio"" class=""radio""> Option 3</label></li>
					</ul>
				</fieldset>
				");
            __builder.AddMarkupContent(49, "<p><a href=\"#top\">[Top]</a></p>\r\n\t\t\t\t");
            __builder.AddMarkupContent(50, "<fieldset id=\"forms__textareas\">\r\n\t\t\t\t\t<legend>Textareas</legend>\r\n\t\t\t\t\t<p>\r\n\t\t\t\t\t\t<label for=\"textarea\">Textarea</label>\r\n\t\t\t\t\t\t<textarea id=\"textarea\" rows=\"8\" cols=\"48\" placeholder=\"Enter your message here\"></textarea>\r\n\t\t\t\t\t</p>\r\n\t\t\t\t</fieldset>\r\n\t\t\t\t");
            __builder.AddMarkupContent(51, "<p><a href=\"#top\">[Top]</a></p>\r\n\t\t\t\t");
            __builder.AddMarkupContent(52, @"<fieldset id=""forms__html5"">
					<legend>HTML5 inputs</legend>
					<p>
						<label for=""ic"">Color input</label>
						<input type=""color"" id=""ic"" value=""#000000"">
					</p>
					<p>
						<label for=""in"">Number input</label>
						<input type=""number"" id=""in"" min=""0"" max=""10"" value=""5"">
					</p>
					<p>
						<label for=""ir"">Range input</label>
						<input type=""range"" id=""ir"" value=""10"">
					</p>
					<p>
						<label for=""idd"">Date input</label>
						<input type=""date"" id=""idd"" value=""1970-01-01"">
					</p>
					<p>
						<label for=""idm"">Month input</label>
						<input type=""month"" id=""idm"" value=""1970-01"">
					</p>
					<p>
						<label for=""idw"">Week input</label>
						<input type=""week"" id=""idw"" value=""1970-W01"">
					</p>
					<p>
						<label for=""idt"">Datetime input</label>
						<input type=""datetime"" id=""idt"" value=""1970-01-01T00:00:00Z"">
					</p>
					<p>
						<label for=""idtl"">Datetime-local input</label>
						<input type=""datetime-local"" id=""idtl"" value=""1970-01-01T00:00"">
					</p>
				</fieldset>
				");
            __builder.AddMarkupContent(53, "<p><a href=\"#top\">[Top]</a></p>\r\n\t\t\t\t");
            __builder.AddMarkupContent(54, @"<fieldset id=""forms__action"">
					<legend>Action buttons</legend>
					<p>
						<input type=""submit"" value=""<input type=submit>"">
						<input type=""button"" value=""<input type=button>"">
						<input type=""reset"" value=""<input type=reset>"">
						<input type=""submit"" value=""<input disabled>"" disabled>
					</p>
					<p>
						<button type=""submit"">&lt;button type=submit&gt;</button>
						<button type=""button"">&lt;button type=button&gt;</button>
						<button type=""reset"">&lt;button type=reset&gt;</button>
						<button type=""button"" disabled>&lt;button disabled&gt;</button>
					</p>
				</fieldset>
				");
            __builder.AddMarkupContent(55, "<p><a href=\"#top\">[Top]</a></p>\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
