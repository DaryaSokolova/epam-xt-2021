const checkParam = (param) => {
    if (param === undefined) {

        throw "Нет параметра";
    }
}


function Service() {
    this.arr = [];
    this.ID = 0;

    this.add = function (obj) {
        checkParam(obj);
        const id = this.ID++;
        this.arr.push({ ...obj, id });
    };

    this.getById = function (id) {
        checkParam(id);

        const obj = this.arr.find(el => el.id === id);

        if (obj === undefined) {
            return null;
        }
        else
            return obj;
    }

    this.getAll = function () {
        return this.arr;
    }

    this.deleteById = function (id) {
        checkParam(id);

        const index = this.arr.findIndex(el => el.id === id);

        if (index === -1) {
            return null;
        }
        else {
            const obj = this.arr[index];
            this.arr.splice(this.arr[index], 1);
            return obj;
        }
    }

    this.updateById = function (id, obj) {
        checkParam(id);
        checkParam(obj);

        const index = this.arr.findIndex(el => el.id === id);

        if (index != -1) {
            const tempObj = this.getById(id);
            this.arr[index] = { ...tempObj, ...obj, id };
        }

    }

    this.replaceById = function (id, obj) {
        checkParam(id);
        checkParam(obj);

        const index = this.arr.findIndex(el => el.id === id);

        if (index != -1) {
            this.arr[index] = { ...obj, id };
        }
    }
}

const user = {
    name: "111111",
    age: 3579759
};

const user1 = {
    name: "Джон",
    age: 30
};

var storage = new Service();
storage.add(user); //принимает объект и позволяет добавить его в коллекцию
storage.add(user1);
storage.add(user1);

//storage.add();
console.log(storage.getById(0)); //принимает id и возвращает найденный объект или NULL если не найден
console.log(storage.getAll()); //возвращает весь массив объектов
//console.log(storage.deleteById(0)); //принимает id и возвращает удаленный объект


//storage.replaceById(1, user); // принимает id и заменяет старый объект - новым
storage.updateById(1, {name: "Vikentii", age: 23}); // принимает id первым параметром и объект-вторым. Обновляет поля объекта новыми значениями
console.log(storage.getAll()); //возвращает весь массив объектов