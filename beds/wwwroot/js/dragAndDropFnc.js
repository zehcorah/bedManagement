//Author: Ryan French Date Complete: 2019/08/06
/*Purpose:  Javascript to handle the drag and drop elements as well as transfer the dragged objects location data to the 
 * Manager.cshtml file to be sent to the controller method Manager(overloaded)
 */

function dragStart(e) {
    e.dataTransfer.effectAllowed = "move";
    e.dataTransfer.setData("Text", e.target.getAttribute("id"));

    var idraggable = e.dataTransfer.getData("Data");
    var id = e.target.getAttribute('id');

    var object = document.getElementById('beingDragged');
    object.value = id;
}

function dragOver(e) {
    e.preventDefault();
    e.stopPropagation();  
}

function drop(e) {
    e.stopPropagation();
    e.preventDefault();

    var idraggable = e.dataTransfer.getData("Data");
    var id = e.target.getAttribute('id');

    var target = document.getElementById('droppedIn');
    target.value = id;
    var data = e.dataTransfer.getData("Text");



    e.target.appendChild(document.getElementById(data));
}
