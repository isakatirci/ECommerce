"use strict";var KTTreeview={init:function(){$("#kt_tree_1").jstree({core:{themes:{responsive:!1}},types:{default:{icon:"fa fa-folder"},file:{icon:"fa fa-file"}},plugins:["types"]}),$("#kt_tree_2").jstree({core:{themes:{responsive:!1}},types:{default:{icon:"fa fa-folder kt-font-warning"},file:{icon:" flaticon2-file  kt-font-warning"}},plugins:["types"]}),$("#kt_tree_2").on("select_node.jstree",function(t,e){var n=$("#"+e.selected).find("a");if("#"!=n.attr("href")&&"javascript:;"!=n.attr("href")&&""!=n.attr("href"))return"_blank"==n.attr("target")&&(n.attr("href").target="_blank"),document.location.href=n.attr("href"),!1}),$("#kt_tree_3").jstree({plugins:["wholerow","checkbox","types"],core:{themes:{responsive:!1},data:[{text:"Same but with checkboxes",children:[{text:"initially selected",state:{selected:!0}},{text:"custom icon",icon:"flaticon2-new-email kt-font-danger"},{text:"initially open",icon:"fa fa-folder kt-font-default",state:{opened:!0},children:["Another node"]},{text:"custom icon",icon:"flaticon2-attention kt-font-waring"},{text:"disabled node",icon:"fa fa-check kt-font-success",state:{disabled:!0}}]},"And wholerow selection"]},types:{default:{icon:"fa fa-folder kt-font-warning"},file:{icon:" flaticon2-file  kt-font-warning"}}}),$("#kt_tree_4").jstree({core:{themes:{responsive:!1},check_callback:!0,data:[{text:"Parent Node",children:[{text:"Initially selected",state:{selected:!0}},{text:"Custom Icon",icon:"flaticon2-poll-symbol kt-font-danger"},{text:"Initially open",icon:"fa fa-folder kt-font-success",state:{opened:!0},children:[{text:"Another node",icon:" flaticon2-file kt-font-waring"}]},{text:"Another Custom Icon",icon:"flaticon2-pie-chart-2 kt-font-waring"},{text:"Disabled Node",icon:"fa fa-check kt-font-success",state:{disabled:!0}},{text:"Sub Nodes",icon:"fa fa-folder kt-font-danger",children:[{text:"Item 1",icon:"flaticon2-file kt-font-waring"},{text:"Item 2",icon:"flaticon2-file kt-font-success"},{text:"Item 3",icon:"flaticon2-file kt-font-default"},{text:"Item 4",icon:"flaticon2-file kt-font-danger"},{text:"Item 5",icon:"flaticon2-file kt-font-info"}]}]},"Another Node"]},types:{default:{icon:"fa fa-folder kt-font-brand"},file:{icon:" flaticon2-file  kt-font-brand"}},state:{key:"demo2"},plugins:["contextmenu","state","types"]}),$("#kt_tree_5").jstree({core:{themes:{responsive:!1},check_callback:!0,data:[{text:"Parent Node",children:[{text:"Initially selected",state:{selected:!0}},{text:"Custom Icon",icon:"flaticon2-settings kt-font-danger"},{text:"Initially open",icon:"fa fa-folder kt-font-success",state:{opened:!0},children:[{text:"Another node",icon:"flaticon2-shield kt-font-waring"}]},{text:"Another Custom Icon",icon:"flaticon2-contract kt-font-waring"},{text:"Disabled Node",icon:"fa fa-check kt-font-success",state:{disabled:!0}},{text:"Sub Nodes",icon:"fa fa-folder kt-font-danger",children:[{text:"Item 1",icon:" flaticon2-file kt-font-waring"},{text:"Item 2",icon:" flaticon2-file kt-font-success"},{text:"Item 3",icon:" flaticon2-file kt-font-default"},{text:"Item 4",icon:" flaticon2-file kt-font-danger"},{text:"Item 5",icon:" flaticon2-file kt-font-info"}]}]},"Another Node"]},types:{default:{icon:"fa fa-folder kt-font-success"},file:{icon:" flaticon2-file  kt-font-success"}},state:{key:"demo2"},plugins:["dnd","state","types"]}),$("#kt_tree_6").jstree({core:{themes:{responsive:!1},check_callback:!0,data:{url:function(t){return"https://keenthemes.com/keen/tools/preview/api/jstree/ajax_data.php"},data:function(t){return{parent:t.id}}}},types:{default:{icon:"fa fa-folder kt-font-brand"},file:{icon:" flaticon2-file  kt-font-brand"}},state:{key:"demo3"},plugins:["dnd","state","types"]})}};jQuery(document).ready(function(){KTTreeview.init()});