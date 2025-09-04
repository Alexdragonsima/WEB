// JavaScript source code
let check = document.getElementById("check");
check.innerHTML = "Hello DOM";
console.log(check.outerHTML);

//append(element);      //Добавляет элемент в конец ноды, а именно перед дескриптором
//prepend(element);     //Добавляет элемент в начало ноды, а именно ,после открывающего дескриптора
//before(element);      //Добавляет элемент перед открыважщим дескриптором
//after(element);      //Добавляет элемент перед открыважщим дескриптором

//Node - это узел дерева.

let configuration = document.getElementById("configuration");
configuration.append("append();");
configuration.prepend("prepend();");
configuration.before("before();");
configuration.after("after();");