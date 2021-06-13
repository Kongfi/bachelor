<template>
  <q-page>
    <div class="text-h5 text-center q-mt-md text-weight-medium">
      Indberet bedækning
    </div>
    <form @submit.prevent.stop="onSubmit" @reset.prevent.stop="onReset">
      <reporting></reporting>

      <q-expansion-item
        v-model="stallionExpand"
        icon="mdi-horse-variant"
        label="Hingste information"
        header-class="bg-blue-3 text-h6 text-white"
      >
        <q-card flat class="borderBlue row col-12 col-md-6">
          <q-card-section class="row col-12 q-gutter-x-sm">
            <stallion class="col-12"></stallion>
          </q-card-section>

          <q-card-section class="row col-12 q-gutter-x-sm">
            <stallionOwner class="col-12"></stallionOwner>
          </q-card-section>
        </q-card>
      </q-expansion-item>

      <q-card flat square class="bg-pink-2 row col-12 col-md-6 q-mt-md">
        <q-card-section class="row col-12 q-gutter-x-sm no-wrap">
          <q-icon
            size="sm"
            class="full-height q-pr-lg text-pink-9"
            name="mdi-lightbulb-on"
          />
          <div>
            <div class="text-body1 text-pink-9 text-weight-medium">
              Har du mere end én bedækning at indberette til denne hingst, kan
              du tilføje flere bedækninger i bunden af formularen
            </div>
          </div>
        </q-card-section>
      </q-card>

      <mareList v-for="item in mareList" :key="item.id"></mareList>
      <div class="flex justify-center q-my-md">
        <q-btn
          color="pink-3"
          icon-right="mdi-text-box"
          label="Tilføj bedækning"
          @click="addToList"
        />
      </div>

      <finalize></finalize>
    </form>
  </q-page>
</template>

<script>
import Reporting from "components/Form/Reporting";
import Stallion from "components/Form/Stallion";
import StallionOwner from "components/Form/StallionOwner";
import MareList from "components/Form/MareList";
import Finalize from "components/Form/Finalize";

export default {
  name: "Index",

  components: {
    Stallion,
    StallionOwner,
    Reporting,
    MareList,
    Finalize
  },

  data() {
    return {
      stallionExpand: true,
      mareList: [{ id: 1 }]
    };
  },

  methods: {
    onSubmit() {
      this.Stallion.data.stallionId.validate();

      if (this.Stallion.data.stallionId.hasError) {
        this.formHasError = true;
      } else if (this.Finalize.data.val !== true) {
        this.$q.notify({
          color: "negative",
          message: "You need to accept the license and terms first"
        });
      } else {
        this.$q.notify({
          icon: "done",
          color: "positive",
          message: "Submitted"
        });
      }
    },

    addToList() {
      this.mareList.push(MareList);
    }
  }
};
</script>

<style lang="scss" scoped>
.borderBlue {
  border-left: $blue-3 7px solid;
}
</style>
