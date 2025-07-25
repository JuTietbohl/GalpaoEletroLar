document.addEventListener('DOMContentLoaded', function () {
    document.querySelectorAll('.btn-detalhes').forEach(function (button) {
        button.addEventListener('click', function () {
            const id = this.getAttribute('data-id');

            fetch(`/Catalogo/DetalhesProduto?id=${id}`)
                .then(response => response.text())
                .then(html => {
                    document.getElementById('modalContainer').innerHTML = html;
                    const modalElement = document.getElementById('modalDetalhes');
                    const modal = new bootstrap.Modal(modalElement);
                    modal.show();
                })
                .catch(error => console.error('Erro ao carregar modal:', error));
        });
    });
});