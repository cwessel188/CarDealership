(function () { // revealing modular pattern

    angular.module('CarDealership').controller('SearchController', function (ngDialog, $http, $resource) {
        var self = this;
        var Car = $resource('/api/search/:id'); // API controller name

        console.log(Car);

        self.cars = Car.query();
        self.searchresults = self.cars;

        self.fetch = function () {
            console.log('fetching cars');
            self.cars = Car.query();
        };

        self.searchmodels = function (searchterm) {
            console.log('searching for model ' + searchterm);
            $http.get('/api/Search/model/' + searchterm)
            .success(function (cars) { // promise pattern
                self.searchresults = cars;
            })
            .error(function () {
                console.log('search by model failed');
            });
        }; // search models

        self.searchdescription = function (descterm) {
            console.log('searching for description ' + descterm);
            $http.get('/api/Search/description/' + descterm)
            .success(function (cars) { // promise pattern
                self.searchresults = cars;
            })
            .error(function () {
                console.log('search by description failed');
            });
        }; // search description

        self.getcarmodels = function (make) {
            console.log(make);
            $http.get('/api/search/' + make)
            .success(function (models) {
                self.models = models
                console.log(models);
            })
            .error(function () {
                console.log('could not fetch models');
            });
        }; // browse by make

        self.clickToOpen = function (car) {

            ngDialog.open({template: 'ModalTemplate.html', data: car});
        }



    }); // DealershipController


    angular.module('CarDealership').controller('AdminController', function () {
        var self = this;

        self.post = function () {
            var car = new bat({ // read data directly from model
                Title: '',
                Price: '',
                Picture: '',
                BriefDescription: '',
                FullDescription: '',
                Range: '',
                ChargeTime: ''
            });

        }; // post()

    }); // AdminController

})();