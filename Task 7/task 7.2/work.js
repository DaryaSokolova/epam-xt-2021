let str = "3.5 +4*10-5.3 /5 =";

const answer = (strForFunc) => {
    const tempStr = strForFunc.match(/\d+(\.\d+)?/g);
    const sign = strForFunc.match(/[-+*/]/g);

    let result = Number(tempStr[0]);

    for (let index = 0; index < tempStr.length - 1; index++) {
        let elNext = Number(tempStr[index + 1]);

        switch (sign[index]) {

            case "+":
                result += elNext;
                break;

            case "-":
                result -= elNext;
                break;

            case "*":
                result *= elNext;
                break;

            case "/":
                result /= elNext;
                break;

            default:
                break;
        }
    }

    return result.toFixed(2);
}

console.log(answer(str));