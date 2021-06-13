<template>
  <div>
    <div class="row col-12">
      <div class="row col-12 ">
        <q-select
          class="col-12 q-pb-none"
          outlined
          v-model="stallionSearch"
          :options="horses"
          option-value="id"
          option-label="name"
          label="Vælg hingst*"
          :rules="[val => !!val || '* Påkrævet']"
        >
        </q-select>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "Stallion",

  data() {
    return {
      stallionSearch: null
    };
  },

  mounted: function() {
    this.$store.dispatch("horseStore/loadHorses");
  },

  computed: {
    horses: {
      get() {
        return this.$store.state.horseStore.horses;
      }
    }
  }
};
</script>

<style lang="scss" scoped></style>
