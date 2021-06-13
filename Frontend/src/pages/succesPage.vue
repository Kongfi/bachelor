<template>
  <q-page padding class="row fit flex justify-center content-center">
    <q-card class="row col-12 col-md-6 q-pa-none">
      <q-card-section class="row col-12">
        <h3 class="col-12 q-mt-sm">Tak for din indberetning</h3>
        <p class="text-body1 col-12">
          Vi har modtaget din indberetning, og vil give svar på mail så snart
          den er godkendt.
        </p>
        <p class="text-body1 text-weight-bold col-12 q-mb-sm">
          Har du flere indberetninger?
        </p>
        <q-btn
          color="primary"
          icon-right="mdi-text-box"
          label="Indberet"
          to="/form"
        />
      </q-card-section>
    </q-card>
  </q-page>
</template>

<script>
export default {
  // name: 'PageName',
};
</script>
