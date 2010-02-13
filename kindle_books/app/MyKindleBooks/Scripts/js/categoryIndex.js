
var ea;
jQuery(document).ready(function() {
    // ea = new EventAggregator();

    $('.category').mouseover(function() {
        var curCategory = $(this);
        $('.subcategoryContainer').hide();
        curCategory.next().show();
    });

    $('.subcategoryContainer').hide();
});
