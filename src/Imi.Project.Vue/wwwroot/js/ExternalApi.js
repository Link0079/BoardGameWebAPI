var harryPotterApp = new Vue({
    el: '#harryPotterApp',
    data: {
        loading: true,
        allCharacters: [],
        onlyStaf: [],
        onlyStudents: [],
        onlyHouses: [],
        onlyFemale: [],
        onlyMale: [],
        onlyWands: [],
        onlyStudentsInHouse: [],
        currentHouse: "",
        countStudentsInHouse: 0,
        countWands: 0,
        countStaff: 0,
        countStudent: 0,
        countHouses: 0,
        countCharacters: 0,
        countFemale: 0,
        countMale: 0,
        seeStudentsInHouse: false,
        seeAllChars: true,
        seeAllStudents: false,
        seeAllStaff: false,
        seeStats: false,
    },
    created:
        function () {
            let self = this;
            self.FetchHPChars();
        },
    methods: {
        FetchHPChars:
            function () {
                let self = this;
                axios.get(harryPotterCharactersApiURL)
                    .then(function (response) {
                        self.allCharacters = response.data
                            .sort(function (a, b) {
                                if (a.name < b.name) { return -1; }
                                if (a.name > b.name) { return 1; }
                                return 0;
                            });
                        self.countCharacters = self.allCharacters.length;
                        self.loading = true;
                    })
                    .catch(function (error) {
                        console.log(error);
                    })
                    .finally(function () {
                        setTimeout(function () {
                            self.loading = false;
                        }, 1000);
                    });
            },
        FetchHPStudents:
            function () {
                let self = this;
                let harryPotterStudentsApiUrl = `${harryPotterCharactersApiURL}/students`;
                axios.get(harryPotterStudentsApiUrl)
                    .then(function (response) {
                        self.onlyStudents = response.data
                            .sort(function (a, b) {
                                if (a.name < b.name) { return -1; }
                                if (a.name > b.name) { return 1; }
                                return 0;
                            });
                        self.countStudent = self.onlyStudents.length;
                    })
                    .catch(function (error) {
                        console.log(error);
                    })
            },
        FetchHPStaff:
            function () {
                let self = this;
                let harryPotterStaffApiUrl = `${harryPotterCharactersApiURL}/staff`;
                axios.get(harryPotterStaffApiUrl)
                    .then(function (response) {
                        self.onlyStaf = response.data
                            .sort(function (a, b) {
                                if (a.name < b.name) { return -1; }
                                if (a.name > b.name) { return 1; }
                                return 0;
                            });

                        self.countStaff = self.onlyStaf.length;
                    })
                    .catch(function (error) {
                        console.log(error);
                    })
            },
        FetchHPHouses:
            function () {
                let self = this;
                self.allCharacters.forEach(function (char, index) {
                    if (char.house != "") {
                        if (self.onlyHouses.length < 1) {
                            self.onlyHouses.push(char.house);
                        }
                        if (self.onlyHouses.indexOf(char.house) == -1) {
                            self.onlyHouses.push(char.house);
                        }
                    }
                });
                self.onlyHouses = self.onlyHouses.sort(function (a, b) {
                    if (a < b) { return -1; }
                    if (a > b) { return 1; }
                    return 0;
                });
                self.countHouses = self.onlyHouses.length;
            },
        FetchHPByGender:
            function () {
                let self = this;
                self.allCharacters.forEach(function (char, index) {
                    if (char.gender == "female") {
                        if (self.onlyFemale.length < 1) {
                            self.onlyFemale.push(char);
                        }
                        if (self.onlyFemale.indexOf(char) == -1) {
                            self.onlyFemale.push(char);
                        }
                    }
                    if (char.gender == "male") {
                        if (self.onlyMale.length < 1) {
                            self.onlyMale.push(char);
                        }
                        if (self.onlyMale.indexOf(char) == -1) {
                            self.onlyMale.push(char);
                        }
                    }
                    self.countFemale = self.onlyFemale.length;
                    self.countMale = self.onlyMale.length;
                })
            },
        FetchHPWands:
            function () {
                let self = this;
                self.allCharacters.forEach(function (char, index) {
                    if (char.wand.wood != "") {
                        if (self.onlyWands.length < 1) {
                            self.onlyWands.push(char);
                        }
                        if (self.onlyWands.indexOf(char) == -1) {
                            self.onlyWands.push(char);
                        }
                    }
                    self.countWands = self.onlyWands.length;
                })
            },
        SeeStudentsInHouse:
            function (house) {
                let self = this;
                self.currentHouse = house;
                let harryPotterStudentsInHouseApiUrl = `${harryPotterCharactersApiURL}/house/${house}`;
                axios.get(harryPotterStudentsInHouseApiUrl)
                    .then(function (response) {
                        self.onlyStudentsInHouse = response.data
                            .sort(function (a, b) {
                                if (a.name < b.name) { return -1; }
                                if (a.name > b.name) { return 1; }
                                return 0;
                            });
                        self.countStudentsInHouse = self.onlyStudentsInHouse.length;
                        self.seeStudentsInHouse = true;
                    })
                    .catch(function (error) {
                        console.log(error);
                    })
            },
        SeeArea:
            function (area) {
                let self = this;
                switch (area) {
                    case "AllChars":
                        self.seeAllChars = true;
                        self.seeAllStudents = false;
                        self.seeAllStaff = false;
                        self.seeStats = false;
                        break;
                    case "AllStudents":
                        self.seeAllChars = false;
                        self.seeAllStudents = true;
                        self.seeAllStaff = false;
                        self.seeStats = false;
                        self.FetchHPStudents();
                        break;
                    case "AllStaff":
                        self.seeAllChars = false;
                        self.seeAllStudents = false;
                        self.seeAllStaff = true;
                        self.seeStats = false;
                        self.FetchHPStaff();
                        break;
                    case "AllStats":
                        self.seeAllChars = false;
                        self.seeAllStudents = false;
                        self.seeAllStaff = false;
                        self.seeStats = true;
                        self.FetchHPHouses();
                        self.FetchHPByGender();
                        self.FetchHPWands();
                        break;
                    default:
                }
            },
    },
});