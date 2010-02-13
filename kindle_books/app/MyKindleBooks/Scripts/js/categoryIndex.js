
var ea;
jQuery(document).ready(function() {
    // ea = new EventAggregator();

    $('#accordion').accordion({ header: '.category', event: 'mouseover' });

    $('#btnActivateNdx').click(function() {
        $('#accordion').accordion('activate', Number($('#txtActivateNdx').val()));
    });
});
