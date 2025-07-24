document.addEventListener("DOMContentLoaded", function () {
    const productType = document.getElementById("TipoProduto");
    const productVolts = document.getElementById("campoVoltagem");
    const productSize = document.getElementById("tamanhoProduto");
    const sizeInput = document.getElementById("tamanhoInput");
    const voltsSelect = document.getElementById("voltagemSelect");

    function updateFields() {
        const selectedValue = productType.value;

        if (selectedValue === "Eletro") {
            console.log("eletro");
            productSize.classList.add("d-none");
            sizeInput.removeAttribute("required");

            productVolts.classList.remove("d-none");
            voltsSelect.setAttribute("required", "required");
        } else if (selectedValue === "Movel") {
            console.log("movel");
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

    if (productType) {
        productType.addEventListener("change", updateFields);
        updateFields();
    }
});
