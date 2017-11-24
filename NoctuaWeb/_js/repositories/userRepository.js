function insertUser(user) {

    var root = firebase.database().ref();

    root.child('users').push(user);

}