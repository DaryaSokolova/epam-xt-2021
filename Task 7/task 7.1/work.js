let str = "у попа была собака"

const newString = (strForFunc) => {
    let tempArr = strForFunc.split(' ');
    let newStr = "";

    tempArr.forEach(element1 => {
        let tempWord = element1.split("");
        let newWord = "";

        tempWord.forEach(element2 => {
            if (tempWord.indexOf(element2) == tempWord.lastIndexOf(element2)) {
                newWord += element2;
            }
        });
        newStr+=newWord + " ";
    });

    return newStr;
}

console.log(newString(str));