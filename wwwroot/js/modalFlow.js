function abrirConfirmacaoCadastro() {
  const modalCadastro = bootstrap.Modal.getInstance(document.getElementById('modalCadastro'));
  modalCadastro.hide();

  setTimeout(() => {
    const modalConfirmacao = new bootstrap.Modal(document.getElementById('modalConfirmaCadastro'));
    modalConfirmacao.show();
  }, 200);
}

function prepararExclusao(id, nome) {
  document.getElementById('produtoIdExcluir').value = id;
  document.getElementById('nomeProdutoExcluir').innerText = nome;
}

function carregarModalDetalhes(id) {
  fetch(`/Catalogo/DetalhesProduto?id=${id}`)
    .then(res => res.text())
    .then(html => {
      // REMOVE qualquer modalDetalhes existente no DOM
      const antigo = document.getElementById("modalDetalhes");
      if (antigo) {
        antigo.remove();
      }

      // Injeta o novo modal
      document.getElementById('modalDetalhesContainer').innerHTML = html;

      // Mostra o novo modal
      const modal = new bootstrap.Modal(document.getElementById('modalDetalhes'));
      modal.show();
    })
    .catch(err => {
      console.error("Erro ao carregar modal:", err);
    });
}

function habilitarEdicao() {
    const modal = document.getElementById('modalDetalhes');
    const inputs = modal.querySelectorAll('input, select');

    inputs.forEach(input => {
        input.disabled = false;
    });

    document.getElementById('edit-button').classList.add('d-none');
    document.getElementById('save-button').classList.remove('d-none');
}


