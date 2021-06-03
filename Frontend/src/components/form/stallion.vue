<template>
  <div>
    <q-card class="row q-my-md">
      <q-card-section class="row col-12 q-gutter-x-sm">
        <h1 class="text-h6 q-mt-none">Hingste information</h1>
        <q-select
          class="col-12"
          outlined
          v-model="stallionSearch"
          :options="horses"
          option-value="id"
          option-label="name"
          label="Hingst FEIF ID*"
          :rules="[val => !!val || '* Påkrævet']"
        >
        </q-select>
      </q-card-section>
    </q-card>
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
  },

  methods: {
    convertHorseObject(horses) {
      horses.map(x => {
        var obj = { id: x.id, desc: x.name };
        return obj;
      });
    }
  }
};
</script>

<style lang="scss" scoped></style>
