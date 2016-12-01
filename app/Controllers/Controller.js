'use strict';

ESAP.controller("dragdrop", function ($scope) {
    $scope.remove = function (scope) {
        scope.remove();
    };

    $scope.toggle = function (scope) {
        scope.toggle();
    };


    $scope.list = [{ "title": "SW", "items": [{ "title": "A" }, { "title": "B" }] },
        { "title": "HW", "items": [{ "title": "C" }, { "title": "D" }] }]
});                                             