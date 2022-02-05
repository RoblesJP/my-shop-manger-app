<template>
  <div class="modal-wrapper">
    <div class="modal-container">
      <div class="modal-content">
        <div class="modal-header">
          <slot name="header">default header</slot>
        </div>
        <div class="modal-body">
          <slot name="body">default body</slot>
        </div>
        <div class="modal-footer">
          <slot name="footer">default footer</slot>
          <button @click="$emit('close')">Cerrar</button>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  setup() {},
};
</script>

<style>
</style>