const simplificar = (strFraccion) => { 
    // Declaro varias variables para poder realizar la simplificación 
    // de una fracción
    let resultado = '', 
        data = strFraccion.split('/'), 
        num = Number(data[0]),  
        denom = Number(data[1]);  
    // Obtengo el máximo entre el num y denom como punto inicial del for
    // y de forma decreciente voy obteniendo el RESIDUO 
    // de la DIVISION del num como denom por 
    // lo que tenga i en esa iteración, hasta que el módulo o residuo 
    // ambas divisiones sea 0. En dicho caso, divido num y denom por dicho
    // i y asigno su RESULTADO tanto a num como a denom (es decir simplifico la
    // fracción)
    for (let i = Math.max(num, denom); i > 1; i--) { 
        if ((num % i == 0) && (denom % i == 0)) { 
            num /= i; 
            denom /= i; 
        } 
    } 
    // Si el denominador es 1 entonces devuelvo el mismo numero, sino concateno num / denom
    if (denom === 1) { 
        resultado = num.toString() 
    } else { 
        resultado = num.toString() + '/' + denom.toString() 
    }     
    // Retorno la variable resultado
    return resultado; 
} // end function simplificar()

console.log(simplificar("4/6"));     //  2/3
console.log(simplificar("10/11"));   // 10/11
console.log(simplificar("100/400")); //  1/4
console.log(simplificar("42405/492806"));