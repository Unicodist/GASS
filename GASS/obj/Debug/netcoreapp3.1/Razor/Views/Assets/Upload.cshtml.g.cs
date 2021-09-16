#pragma checksum "C:\HtmlFiles\GASS\GASS\Views\Assets\Upload.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ba1305b6a0932ae8dc64a28c83633d892b7577d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Assets_Upload), @"mvc.1.0.view", @"/Views/Assets/Upload.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\HtmlFiles\GASS\GASS\Views\_ViewImports.cshtml"
using GASS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\HtmlFiles\GASS\GASS\Views\_ViewImports.cshtml"
using GASS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ba1305b6a0932ae8dc64a28c83633d892b7577d", @"/Views/Assets/Upload.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"792ae6809f9bfc3ee449a666f1cc9e8d797c0e08", @"/Views/_ViewImports.cshtml")]
    public class Views_Assets_Upload : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AssetUploadViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("newAssetForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Assets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadAssetAction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\HtmlFiles\GASS\GASS\Views\Assets\Upload.cshtml"
  
    var errors = TempData["error_list"];
    ViewData["Title"] = "Contribute as new asset...";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""../css/style.css"" />
<style>
    #modalForeground {
        display: flex;
        flex-direction: row;
        justify-content: space-around;
    }

    #priceLabels{
        display:flex;
    }

    .tag-input {
        border: 1px solid black;
        display: block;
        padding: 5px;
    }

        .tag-input #tag-group {
            display: -webkit-inline-box;
            display: -ms-inline-flexbox;
            display: inline-flex;
            overflow-wrap: break-word;
        }

            .tag-input #tag-group .tag {
                border-radius: 5rem;
                margin: 0 5px;
                height: 20px;
                background-color: #696969;
                color: whitesmoke;
                padding: 3px;
                display: -webkit-box;
                display: -ms-flexbox;
                display: flex;
                -webkit-box-align: center;
                -ms-flex-align: center;
                align-i");
            WriteLiteral(@"tems: center;
                font-size: 12px;
            }

                .tag-input #tag-group .tag i {
                    margin-left: 2px;
                    height: 100%;
                    display: -webkit-box;
                    display: -ms-flexbox;
                    display: flex;
                    -webkit-box-align: center;
                    -ms-flex-align: center;
                    align-items: center;
                    cursor: pointer;
                }

                    .tag-input #tag-group .tag i:hover {
                        background-color: red;
                    }

        .tag-input input[type=text] {
            border: none;
            height: 100%;
        }
    /*# sourceMappingURL=style.css.map */
</style>
<div class=""modal"" id=""myModal"">
    <div class=""modal-dialo"" id=""modalForeground"">
        <div class=""modal-content text-dark w-auto"">

            <!-- Modal Header -->
            <div class=""modal-header"">
               ");
            WriteLiteral(@" <h4 class=""modal-title"">Add a new Category</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>

            <!-- Modal body -->
            <div class=""modal-body"">
                <label>Enter category name:</label>
                <input type=""text"" class=""input-group"" id=""addCatTitle"" />
                <label>Description:</label>
                <textarea type=""text"" class=""input-group"" id=""addCatDes""></textarea>
                <button class=""btn btn-primary mt-1"" id=""addBtn"">Add</button>
            </div>

        </div>
    </div>
</div>
<div id=""uploadContainer"" class=""row mt-1"">
    <img id=""pgbg"" src=""../images/pubg_background.jpg"" />
    <div class=""col-md-4""></div>
    <div class=""col-sm-12 col-md-6"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ba1305b6a0932ae8dc64a28c83633d892b7577d8152", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <label for=""inputUser"">Title:</label>
                <input type=""text"" class=""form-control"" id=""assetTitle"" required placeholder=""Title"" name=""title"">
            </div>
            <div class=""form-group"">
                <label for=""inpDesc"">Description</label>
                <textarea rows=""10"" class=""form-control"" id=""inpDesc"" placeholder=""Tell us about your assets"" name=""description""></textarea>
            </div>
            <div class=""form-group"">
                <label>Select Category(s)</label>
                <div class=""tag-input"">
                    <div id=""tag-group"">
                    </div>
                    <input id=""data"" type=""hidden"" name=""tags"" class=""form-control"" />
                    <input id=""cat"" list=""categoryList"" type=""text"" class=""form-control"" />
                </div>
                <datalist id=""categoryList"">
");
#nullable restore
#line 113 "C:\HtmlFiles\GASS\GASS\Views\Assets\Upload.cshtml"
                     foreach (var item in ViewBag.game_categories)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ba1305b6a0932ae8dc64a28c83633d892b7577d9681", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 115 "C:\HtmlFiles\GASS\GASS\Views\Assets\Upload.cshtml"
                           WriteLiteral(item.category_name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 115 "C:\HtmlFiles\GASS\GASS\Views\Assets\Upload.cshtml"
AddHtmlAttributeValue("", 4222, item.category_description, 4222, 26, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 116 "C:\HtmlFiles\GASS\GASS\Views\Assets\Upload.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </datalist>
            </div>
            <div class=""form-group"">
                <label>Choose your zip file</label>
                <input type=""file"" class=""form-control-file"" name=""assetFile"" accept="".zip"">
            </div>
            <div class=""form-group"">
                <div class=""custom-control custom-switch"">
                    <input type=""checkbox"" class=""custom-control-input"" id=""switch1"" name=""price"">
                    <label class=""custom-control-label"" for=""switch1"">Add price</label>
                </div>
            </div>
            <div id=""prices"" class=""form-group d-none"">
                <div id=""priceRads"">
                    <input type=""radio"" value=""0"" class=""btn-check"" name=""priceTag"" id=""option1"" autocomplete=""off"" checked />
                    <input type=""radio"" value=""10"" class=""btn-check"" name=""priceTag"" id=""option2"" autocomplete=""off"" checked />
                    <input type=""radio"" value=""20"" class=""btn-check"" name=""priceTag"" id");
                WriteLiteral(@"=""option3"" autocomplete=""off"" />
                </div>
                <div class=""btn-group-lg d-flex"">
                    <div id=""priceLabels"" class=""btn-group-lg"">
                        <label class=""btn btn-light btn-dark pr_label"" for=""option1"">$0</label>

                        <label class=""btn btn-light pr_label"" for=""option2"">$10</label>

                        <label class=""btn btn-light pr_label"" for=""option3"">$20</label>

                        <input id='customPriceEntry' type='number' class='form-control d-none' />
                    </div>
                    <label id=""customPriceTrigger"" class=""btn btn-light"">Custom</label>
                </div>
            </div>
            <button type=""submit"" class=""btn btn-primary"">Contribute</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""col-md-4""></div>
</div>
<!-- form validator -->
<script>
    $(document).ready(function () {
        $(""#newAssetForm"").validate({
            rules: {
                title: {
                    required: true,
                    minlength: 5
                },
                description: {
                    required: true,
                    minlength: 15
                },
                assetFile: ""required""
            }
        });
    });
</script>
<!-- hide and show price labels -->
<script>
    $('#switch1').change(
        function () {
            if ($(this).is(':checked')) {
                $('#prices').removeClass('d-none');
            }
            else {
                $('#prices').addClass('d-none');
                $(""#option1"").attr('checked', 'checked');
            }
        });
</script>
<!--change colors of price buttons-->
<script>
    $(document).on('click','.pr_label',function () {
        $('.pr_label').remov");
            WriteLiteral(@"eClass('btn-dark');
        $(this).addClass('btn-dark');
    });
</script>
<!-- Description handler -->
<script>
    var tagList = new Set(); //using set to avoid duplicate category entries
    $(document).on(""click"", "".close-tag"", function () {
        $(this).parent('div').remove();
        tagList.delete($(this).siblings('span').text());
        $('#data').val(Array.from(tagList).join(','));
    });

    //following is what happens when a new description is added
    $(""#cat"").keypress(function (event) {
        if (event.key == ',' || event.key == ' ' || event.key == 'Enter') {
            event.preventDefault();
            var newTag = $('#cat').val();
            tagList.add(newTag);
            $('#data').val(Array.from(tagList).join(','));
            $('#tag-group').html('');
            tagList.forEach(a => {
                $(""#tag-group"").append(""<div class='tag'><span>"" + a + ""</span><i class='fa fa-times close-tag'></i></div>"");
            });
            $(""#cat"").val");
            WriteLiteral(@"('');
        }
    });
</script>
<!--Custom Price label-->
<script>
    $(document).on('click', '#customPriceTrigger', function () {
        $('#customPriceEntry').toggleClass('d-none')
    });

    $(document).on('keypress', '#customPriceEntry', function (event) {
        if (event.key == 'Enter') {
            event.preventDefault();
            $('#customRad').remove();
            $('#customPriceLabel').remove();
            $('#priceRads').append(""<input type='radio' value='"" + $('#customPriceEntry').val() + ""' class='btn-check' name='priceTag' id='customRad' autocomplete='off' />"");
            $('#priceLabels').append(""<label style='display:none;' id='customPriceLabel' for='customRad' class='btn btn-light pr_label'>$"" + $('#customPriceEntry').val() + ""</label>"");
            $('#customPriceLabel').show('slow');
            $(this).remove();
            $('#customPriceLabel').click();
        }
    });
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AssetUploadViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591