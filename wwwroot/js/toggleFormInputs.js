const productType = document.getElementById("TipoProduto");
const productVolts = document.getElementById("campoVoltagem");
const productSize = document.getElementById("tamanhoProduto");
const sizeInput = document.getElementById("tamanhoInput");
const voltsSelect = document.getElementById("voltagemSelect");

function updateFields() {
    const selectedValue = productType.value;

    if (selectedValue === "Eletro") {
        productSize.classList.add("d-none");
        sizeInput.removeAttribute("required");

        productVolts.classList.remove("d-none");
        voltsSelect.setAttribute("required", "required");
    } else if (selectedValue === "Movel") {
        productSize.classList.remove("d-none");
        sizeInput.setAttribute("required", "required");

        productVolts.classList.add("d-none");
        voltsSelect.removeAttribute("required");
    } else {
        productSize.classList.add("d-none");
        sizeInput.removeAttribute("required");

        productVolts.classList.add("d-none");
        voltsSelect.removeAttribute("required");
    }
}


productType.addEventListener("change", updateFields);

document.addEventListener("DOMContentLoaded", updateFields);