function mostrarToast(id) {
  const toast = document.getElementById(id);
  if (!toast) return;

  // Resetar caso esteja reaparecendo
  toast.style.display = 'none';
  void toast.offsetWidth;

  toast.style.display = 'block';

  setTimeout(() => {
    toast.style.display = 'none';
  }, 3000);
}

function confirmarExclusao() {
  mostrarToast('toastExcluido');
}

function confirmarAdicao() {
  mostrarToast('toastAdicionado');
}

function confirmarSalvamento() {
  mostrarToast('toastSalvo');
}
