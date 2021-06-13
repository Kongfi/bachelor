<template>
  <div>
    <q-expansion-item
      v-model="breedingExpand"
      class="q-mt-md"
      icon="mdi-horse-variant"
      label="Bedækning information"
      header-class="bg-pink-3 text-h6 text-white"
    >
      <q-card flat class="borderPink row col-12 col-md-6">
        <q-card-section class="row col-12 q-gutter-x-sm">
          <mare class="col-12"></mare>
        </q-card-section>

        <q-card-section class="row col-12 q-gutter-x-sm">
          <mareOwner class="col-12"></mareOwner>
        </q-card-section>

        <q-card-section class="row col-12 q-gutter-x-sm">
          <breeding class="col-12"></breeding>
        </q-card-section>

        <q-card-section class="row col-12 q-gutter-x-sm">
          <pregnancy class="col-12"></pregnancy>
        </q-card-section>
      </q-card>
    </q-expansion-item>
  </div>
</template>

<script>
import Mare from "components/Form/Mare";
import MareOwner from "components/Form/MareOwner";
import Breeding from "components/Form/Breeding";
import Pregnancy from "components/Form/Pregnancy";

export default {
  name: "MareList",

  components: {
    Mare,
    MareOwner,
    Breeding,
    Pregnancy
  },

  data() {
    return {
      breedingExpand: true,
      mareList: [{ id: 1 }]
    };
  },

  methods: {}
};
</script>

<style lang="scss" scoped>
.borderPink {
  border-left: $pink-3 7px solid;
}
</style>
