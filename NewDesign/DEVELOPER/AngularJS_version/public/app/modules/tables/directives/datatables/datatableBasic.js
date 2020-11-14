define(['modules/tables/module',
    'datatables',
    'datatables-responsive',
    'datatables-colvis',
    'datatables-tools',
    'datatables-bootstrap'
], function (module) {

    'use strict';

    return module.registerDirective('datatableBasic', function ($compile) {
        return {
            restrict: 'A',
            scope: {
                tableOptions: '='
            },
            link: function (scope, element, attributes) {
                /* // DOM Position key index //

                 l - Length changing (dropdown)
                 f - Filtering input (search)
                 t - The Table! (datatable)
                 i - Information (records)
                 p - Pagination (paging)
                 r - pRocessing
                 < and > - div elements
                 <"#id" and > - div with an id
                 <"class" and > - div with a class
                 <"#id.class" and > - div with an id and class

                 Also see: http://legacy.datatables.net/usage/features
                 */

                var options = {
                    "sDom": "<'dt-toolbar'<'col-xs-12 col-sm-6'f><'col-sm-6 col-xs-12 hidden-xs'l>r>" +
                        "t" +
                        "<'dt-toolbar-footer'<'col-sm-6 col-xs-12 hidden-xs'i><'col-xs-12 col-sm-6'p>>",
                    oLanguage:{
                        "sSearch": "<span class='input-group-addon input-sm'><i class='glyphicon glyphicon-search'></i></span> ",
                        "sLengthMenu": "_MENU_"
                    },
                    "autoWidth": false,
                    "smartResponsiveHelper": null,
                    "preDrawCallback": function () {
                        // Initialize the responsive datatables helper once.
                        if (!this.smartResponsiveHelper) {
                            this.smartResponsiveHelper = new ResponsiveDatatablesHelper(element, {
                                tablet: 1024,
                                phone: 480
                            });
                        }
                    },
                    "rowCallback": function (nRow) {
                        this.smartResponsiveHelper.createExpandIcon(nRow);
                    },
                    "drawCallback": function (oSettings) {
                        this.smartResponsiveHelper.respond();
                    }
                };

                if(attributes.tableOptions){
                    options = angular.extend(options, scope.tableOptions)
                }

                var _dataTable;

                var childFormat = element.find('.smart-datatable-child-format');
                if(childFormat.length){
                    var childFormatTemplate = childFormat.remove().html();
                    element.on('click', childFormat.data('childControl'), function () {
                        var tr = $(this).closest('tr');

                        var row = _dataTable.row( tr );
                        if ( row.child.isShown() ) {
                            // This row is already open - close it
                            row.child.hide();
                            tr.removeClass('shown');
                        }
                        else {
                            // Open this row
                            var childScope = scope.$new();
                            childScope.d = row.data();
                            var html = $compile(childFormatTemplate)(childScope);
                            row.child( html ).show();
                            tr.addClass('shown');
                        }
                    })
                }

                _dataTable =  element.DataTable(options);

            }
        }
    });
});
