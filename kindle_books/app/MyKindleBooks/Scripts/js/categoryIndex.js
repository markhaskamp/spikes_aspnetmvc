function categoryMouseOver() {
    console.log($(this));
}

var ea;
jQuery(document).ready(function() {

    ea = new EventAggregator();
    ea.subscribe('EVT_CATEGORY_MOUSEOVER', 'index_categoryMouseOver', categoryMouseOver);

    $('.category').mouseover(function() {
        var curCategory = $(this);
        curCategory.next().show();
    });

    $('.subcategoryContainer').mouseleave(function() {
        $(this).hide();
    });

    $('.subcategoryContainer').hide();


});
