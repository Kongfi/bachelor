<template>
  <div>
    <div class="row">
      <div class="row col-12">
        <h1 class="text-h6 q-mt-none">Oplysninger om hoppeejer/holder</h1>
        <q-input
          class="col-12"
          outlined
          v-model="mareOwnerName"
          label="Ejer/holders fulde navn*"
          :rules="[val => !!val || '* Påkrævet']"
        ></q-input>
        <q-input
          class="col-12"
          outlined
          v-model="mareOwnerCountry"
          label="Land*"
          :rules="[val => !!val || '* Påkrævet']"
        ></q-input>
        <q-input
          class="col-12"
          outlined
          type="number"
          v-model="mareOwnerZipcode"
          label="Postnr.*"
          :rules="[val => !!val || '* Påkrævet']"
        ></q-input>
        <q-input
          class="col-12"
          outlined
          v-model="mareOwnerCity"
          label="By*"
          :rules="[val => !!val || '* Påkrævet']"
        ></q-input>
        <q-input
          class="col-12"
          outlined
          v-model="mareOwnerAddress"
          label="Vej og husnr."
          :rules="[val => !!val || '* Påkrævet']"
        ></q-input>
        <q-input
          class="col-12"
          outlined
          type="tel"
          v-model="mareOwnerPhone"
          label="Telefon*"
          :rules="[val => !!val || '* Påkrævet']"
        ></q-input>
        <q-input
          class="col-12"
          outlined
          type="email"
          v-model="mareOwnerEmail"
          label="E-mail*"
          :rules="[
            val => !!val || '* Påkrævet',
            val =>
              val.includes('@') ||
              '* Indtast venligst en korrekt email-adresse',
            val =>
              val.includes('.') || '* Indtast venligst en korrekt email-adresse'
          ]"
          debounce="500"
        ></q-input>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "MareOwner",
  data() {
    return {
      mareOwnerName: "",
      mareOwnerCountry: "",
      mareOwnerAddress: "",
      mareOwnerZipcode: "",
      mareOwnerCity: "",
      mareOwnerPhone: "",
      mareOwnerEmail: ""
    };
  }
};
</script>

<style lang="scss" scoped></style>
