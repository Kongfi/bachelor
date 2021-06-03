<template>
  <div>
    <q-card class="row q-my-md">
      <q-card-section class="row col-12">
        <h1 class="text-h6 col-12 q-mt-none">
          Oplysninger om hingsteejer/holder
        </h1>

        <div class="text-body1 col-12">
          Rasputin Hansen
        </div>
        <div class="text-body1 col-12">
          8700 Horsens
        </div>
        <div class="text-body1 col-12">
          Danmark
        </div>
        <div class="text-body1 col-12">
          email@email.com
        </div>
        <div class="text-body1 col-12">
          12341231
        </div>
      </q-card-section>
      <q-card-section class="q-pt-none">
        <div class="text-body1 text-weight-medium" label="">
          Ejerskab af hingst
        </div>
        <q-option-group
          v-model="group"
          :options="options"
          color="primary"
        ></q-option-group>
      </q-card-section>
    </q-card>
  </div>
</template>

<script>
export default {
  name: "ComponentName",
  data() {
    return {
      group: "",
      options: [
        {
          label: "Ejer af hingst",
          value: "owner"
        },
        {
          label: "Holder af hingst",
          value: "caretaker"
        }
      ]
    };
  }
};
</script>

<style lang="scss" scoped></style>
