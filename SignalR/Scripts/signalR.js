
$.connection.hub.start()
	.done(function() {
		$.connection.myHub.server.announce("helllo");
		console.log("worked.");
	})
	.fail(function() { });

$.connection.myHub.client.announce = function(message) {
	console.log(message);
	$('#myMessage').append(message);
}