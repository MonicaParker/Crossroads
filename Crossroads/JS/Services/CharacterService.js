(function () {
    angular.module('C').factory('characterService', function ($resource) {
        var self = this;

        //Resource representing a character.
        var Character = $resource('api/characters/:id');

        //Fetch all characters from the controller.
        var characters = function () {
            self.characters = Character.query();
        }

        //Getting the complete list of characters from the controller.
        

    })

})()