let str = "3.5 +4*10-5.3 /5 =";

const answer = (strForFunc) => {
    const tempStr = strForFunc.match(/\d+(\.\d+)?/g);
    const tempNotNumber = strForFunc.match(/[-+*/]/g);

    let result = Number(tempStr[0]);

    for (let index = 0; index < tempStr.length - 1; index++) {
        let elTwo = Number(tempStr[index + 1]);

        switch (tempNotNumber[index]) {

            case "+":
                result += elTwo;
                break;

            case "-":
                result -= elTwo;
                break;

            case "*":
                result *= elTwo;
                break;

            case "/":
                result /= elTwo;
                break;

            default:
                break;
        }
    }

    return result.toFixed(2);
}

console.log(answer(str));