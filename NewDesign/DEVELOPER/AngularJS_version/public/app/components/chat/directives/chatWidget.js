define(['components/chat/module'], function (module) {
    "use strict";

    module.registerDirective('chatWidget', function (ChatApi) {
        return {
            replace: true,
            restrict: 'E',
            templateUrl: 'app/components/chat/directives/chat-widget.tpl.html',
            scope: {},
            link: function (scope, element) {
                scope.newMessage = '';

                scope.sendMessage = function () {
                    ChatApi.sendMessage(scope.newMessage);
                    scope.newMessage = '';
                };

                scope.messageTo = function(user){
                    scope.newMessage += (user.username + ', ');
                };

                ChatApi.initialized.then(function () {
                    scope.chatMessages = ChatApi.messages;
                });
                scope.$watch(function () {
                    return ChatApi.messages.length
                }, function (count) {
                    if (count){
                        var $body = $('.chat-body', element);
                        $body.animate({scrollTop: $body[0].scrollHeight});
                    }
                })
            }
        }
    })


});