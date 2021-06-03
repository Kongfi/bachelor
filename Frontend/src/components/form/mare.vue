<template>
  <div>
    <q-card class="row q-my-md">
      <q-card-section class="row col-12 q-gutter-x-sm">
        <h1 class="text-h6 q-mt-none">Hoppe information</h1>
        <q-input
          class="col-12"
          outlined
          type="search"
          v-model="mareID"
          label="Hoppe FEIF ID*"
          :rules="[val => !!val || '* Påkrævet']"
        >
          <template v-slot:append>
            <q-icon name="mdi-magnify" />
          </template>
        </q-input>
      </q-card-section>
    </q-card>
  </div>
</template>

<script>
export default {
  name: "Mare",

  data() {
    return {
      mareID: "",
      mareName: "",
      mareFrom: "",
      mareStable: ""
    };
  }
};
</script>

<style lang="scss" scoped>
.mareFrom {
  @media (max-width: $breakpoint-sm-max) {
    padding-left: 0;
    margin-top: 8px;
  }
}
.mareStable {
  @media (max-width: $breakpoint-sm-max) {
    padding-left: 0;
    margin-top: 8px;
  }
}
</style>
