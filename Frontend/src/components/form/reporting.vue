<template>
  <div>
    <q-expansion-item
      v-model="reportExpand"
      class="q-my-md"
      icon="mdi-text-box"
      label="Indberetning"
      header-class="bg-primary text-h6 text-white"
    >
      <q-card flat class="borderPrimary row">
        <q-card-section class="row col-12">
          <q-option-group
            class="col-12"
            v-model="group"
            :options="options"
            color="primary"
          />
          <p class="q-mt-sm q-mb-none" v-if="group == 'intime'">
            Pris <span class="text-weight-bold">DKK 370,00</span> inkl. moms
          </p>
          <p class="q-mt-sm q-mb-none" v-if="group == 'delayed'">
            Pris <span class="text-weight-bold">DKK 490,00</span> inkl. moms
          </p>
          <p class="q-mt-sm q-mb-none" v-if="group == 'nextyear'">
            Pris <span class="text-weight-bold">DKK 1.370,00</span> inkl. moms
          </p>
        </q-card-section>
      </q-card>
    </q-expansion-item>
  </div>
</template>

<script>
export default {
  // name: 'ComponentName',
  data() {
    return {
      reportExpand: true,
      group: "",
      options: [
        {
          label: "Rettidig",
          value: "intime"
        },
        {
          label: "Forsinket",
          value: "delayed"
        },
        {
          label: "Efter årets udgang",
          value: "nextyear"
        }
      ]
    };
  }
};
</script>

<style lang="scss" scoped>
.borderPrimary {
  border-left: $primary 7px solid;
}
</style>
