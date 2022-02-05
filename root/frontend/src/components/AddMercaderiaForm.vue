<template>
  <modal>
    <template v-slot:header>
      AddMercaderiaForm
    </template>
    <template v-slot:body>
      Form body
    </template>
    <template v-slot:footer>
      <button>Add</button>
    </template>
  </modal>
</template>

<script>
import Modal from "./Modal.vue";

export default {
  name: "AddMercaderiaForm",
  components: {
    Modal,
  },

  setup() {},
};
</script>
